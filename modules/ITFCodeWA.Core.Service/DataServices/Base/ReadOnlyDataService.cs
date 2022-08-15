using ITFCodeWA.Core.Data.Base.Interface;
using ITFCodeWA.Core.Domain.Repositories.Base.Interfaces;
using ITFCodeWA.Core.Models.Common.Base.Interfaces;
using ITFCodeWA.Core.Models.QueryFilters;
using ITFCodeWA.Core.Models;
using ITFCodeWA.Core.Services.DisposablePattern;
using ITFCodeWA.Core.Services.DataServices.Base.Interfaces;
using Microsoft.Extensions.Logging;
using ITFCodeWA.Core.Services.Operating.Interfaces;
using AutoMapper;
using System.Linq.Expressions;
using System.Reflection;
using ITFCodeWA.Core.Models.QueryFilters.Base.Interfaces;
using ITFCodeWA.Core.Models.QueryFilters.Single;
using ITFCodeWA.Core.Services.FiltersHandlers.Diapason;
using ITFCodeWA.Core.Services.FiltersHandlers.Single;
using ITFCodeWA.Core.Models.QueryFilters.Diapason;
using ITFCodeWA.Core.Models.QueryFilters.Range;
using ITFCodeWA.Core.Services.FiltersHandlers.Range;
using ITFCodeWA.Core.Services.Helpers;
using Microsoft.EntityFrameworkCore;

namespace ITFCodeWA.Core.Services.DataServices.Base
{
    public abstract class ReadOnlyDataService<TRepository, TEntity, TEntityModel, TKey> : DisposableBase, IReadOnlyDataService<TEntityModel, TKey>
        where TRepository : class, IRepository<TEntity, TKey>
        where TEntity : class, IEntity<TKey>
        where TEntityModel : class, IModel<TKey>
        where TKey : IComparable
    {
        #region Private & Protected Fields 

        protected ILogger<ReadOnlyDataService<TRepository, TEntity, TEntityModel, TKey>> _logger;
        protected ICurrentUserService _currentUserService;
        protected IMapper _mapper;
        protected TRepository _repository;

        #endregion

        #region Constructors 

        public ReadOnlyDataService(
            ILogger<ReadOnlyDataService<TRepository, TEntity, TEntityModel, TKey>> logger,
            ICurrentUserService currentUserService,
            IMapper mapper,
            TRepository repository)
        {
            _logger = logger;
            _currentUserService = currentUserService;
            _mapper = mapper;
            _repository = repository;
        }

        #endregion

        #region IReadonlyDataService Implementation

        public virtual async Task<bool> ExistsAsync(TKey id, CancellationToken cancellationToken = default)
            => await _repository.ExistsAsync(id, cancellationToken);

        public virtual async Task<TEntityModel> GetByIdAsync(TKey id, CancellationToken cancellationToken = default)
            => Map(await _repository.FindAsync(id, true, cancellationToken));

        public virtual async Task<PageResult<TEntityModel>> GetPageAsync(QueryOptions queryOptions, CancellationToken cancellationToken = default)
        {
            ValidateQueryOptions(queryOptions);

            var query = _repository.GetDBSetQuery();

            //query = ApplySpecialFiltering(query, queryOptions);
            query = ApplyFiltering(query, queryOptions);
            query = ApplySorting(query, queryOptions);

            var items = await query
                .Skip(queryOptions.Skip)
                .Take(queryOptions.Take)
                .AsNoTracking()
                .Select(x => _mapper.Map<TEntityModel>(x))
                .ToListAsync(cancellationToken);

            return new PageResult<TEntityModel>
            {
                Total = await query.CountAsync(cancellationToken),
                Items = items,
            };
        }

        public virtual async Task<object> GetFilterValues(string columnName, QueryOptions queryOptions, CancellationToken cancellationToken = default)
            => await Task.Run<object>(() => throw new NotImplementedException());

        #endregion

        #region Private && Protected Property 

        protected virtual IQueryable<TEntity> ApplyFiltering(IQueryable<TEntity> query, QueryOptions queryOptions)
        {
            var filters = queryOptions.Filters;

            if (filters == null || !filters.Any()) 
                return query;

            foreach (var groupedFilters in filters.GroupBy(a => a.PropertyName.ToLowerInvariant()))
            {
                Expression<Func<TEntity, bool>> andExpression = null;

                foreach (var queryFilter in groupedFilters)
                {
                    CheckFilter(queryFilter);

                    Expression<Func<TEntity, bool>> expr = queryFilter switch
                    {
                        BoolSingleFilter filter => new BoolSingleFilterHandler(filter).Handle<TEntity>(),
                        DateSingleFilter filter => new DateSingleFilterHandler(filter).Handle<TEntity>(),
                        GuidSingleFilter filter => new GuidSingleFilterHandler(filter).Handle<TEntity>(),
                        NumericSingleFilter filter => new NumericSingleFilterHandler(filter).Handle<TEntity>(),
                        StringSingleFilter filter => new StringSingleFilterHandler(filter).Handle<TEntity>(),
                        DateRangeFilter filter => new DateRangeFilterHandler(filter).Handle<TEntity>(),
                        GuidRangeFilter filter => new GuidRangeFilterHandler(filter).Handle<TEntity>(),
                        NumericRangeFilter filter => new NumericRangeFilterHandler(filter).Handle<TEntity>(),
                        StringRangeFilter filter => new StringRangeFilterHandler(filter).Handle<TEntity>(),
                        DateDiapasonFilter filter => new DateDiapasonFilterHandler(filter).Handle<TEntity>(),
                        NumericDiapasonFilter filter => new NumericDiapasonFilterHandler(filter).Handle<TEntity>(),
                        _ => null
                    };

                    if (expr != null)
                        andExpression = andExpression == null ? expr : ExpressionFactory.And(andExpression, expr);
                }

                if (andExpression != null)
                    query = query.Where(andExpression);
            }

            return query;
        }

        protected virtual IQueryable<TEntity> ApplySorting(IQueryable<TEntity> queryable, QueryOptions queryOptions)
        {
            try
            {
                string sortField = queryOptions.SortField;

                if (string.IsNullOrWhiteSpace(sortField))
                    return queryable;

                bool isAsc = queryOptions.IsAsc;

                var item = Expression.Parameter(typeof(TEntity), "item");
                var property = GetProperty(item, sortField);
                var lambda = Expression.Lambda(property, item);

                // ReSharper disable once ReplaceWithSingleCallToSingle
                var method = typeof(Queryable).GetMethods(BindingFlags.Static | BindingFlags.Public)
                    .Where(a => a.Name == $"OrderBy{(isAsc ? string.Empty : "Descending")}")
                    .Where(a => a.GetParameters().Length == 2)
                    .Single();

                method = method.MakeGenericMethod(new[] { typeof(TEntity), property.Type });
                return (IQueryable<TEntity>)method.Invoke(method, new object[] { queryable, lambda });
            }
            catch
            {
                return queryable;
            }
        }

        protected virtual void ValidateQueryOptions(QueryOptions queryOptions) 
        {
            ArgumentNullException.ThrowIfNull(queryOptions);
        }

        protected TEntityModel Map(TEntity entity)
        => _mapper.Map<TEntityModel>(entity);

        protected TEntity Map(TEntityModel entity)
            => _mapper.Map<TEntity>(entity);

        protected IList<TEntityModel> Map(IEnumerable<TEntity> entity)
            => _mapper.Map<IList<TEntityModel>>(entity);

        protected IList<TEntity> Map(IEnumerable<TEntityModel> entities)
            => _mapper.Map<IList<TEntity>>(entities);

        private void CheckFilter(IQueryFilter filter)
        {
            var propertyName = filter.PropertyName.Split('.');
            var type = typeof(TEntity);
            PropertyInfo entityPropertyInfo = null;

            foreach (var part in propertyName)
            {
                entityPropertyInfo = type.GetProperty(part, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                if (entityPropertyInfo is not null)
                    type = entityPropertyInfo.PropertyType;
                else
                    break;
            }

            if (entityPropertyInfo == null)
                throw new ArgumentException($"Can not find '{filter.PropertyName}' property " + $"for '{typeof(TEntity).FullName}' entity type");
        }

        private MemberExpression GetProperty(ParameterExpression item, string propertyName)
        {
            MemberExpression res = null;

            var properties = propertyName.Split('.');

            foreach (var property in properties)
            {
                if (res == null)
                    res = Expression.Property(item, property);
                else
                    res = Expression.Property(res, property);
            }

            return res;
        }

        #endregion
    }
}