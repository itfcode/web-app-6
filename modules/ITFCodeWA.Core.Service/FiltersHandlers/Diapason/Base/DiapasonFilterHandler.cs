using ITFCodeWA.Core.Models.QueryFilters.Diapason.Base.Intrefaces;
using ITFCodeWA.Core.Services.FiltersHandlers.Base;
using System.Linq.Expressions;

namespace ITFCodeWA.Core.Services.FiltersHandlers.Diapason.Base
{
    public abstract class DiapasonFilterHandler<TFilter, TValue> :
        FilterHandler<TFilter> where TFilter : class, IQueryDiapasonFilter<TValue>
    {
        #region Constractor

        protected DiapasonFilterHandler(TFilter filter) : base(filter) { }

        #endregion

        #region Public Methods 

        public override Expression<Func<TEntity, bool>> Handle<TEntity>()
        {
            var item = Expression.Parameter(typeof(TEntity), "item");

            var property = GetProperty(item, _filter.PropertyName);

            var valueFrom = GetValue(GetDiapasonStart(), property.Type);
            var valueTo = GetValue(GetDiapasonFinish(), property.Type);

            var conditionFrom = Expression.GreaterThanOrEqual(property, valueFrom);
            var conditionTo = Expression.LessThanOrEqual(property, valueTo);
            var conditionFromAndTo = Expression.AndAlso(conditionFrom, conditionTo);

            return Expression.Lambda<Func<TEntity, bool>>(conditionFromAndTo, item);
        }

        #endregion

        #region Private && Protected Methods 

        protected virtual TValue GetDiapasonStart() => _filter.From;

        protected virtual TValue GetDiapasonFinish() => _filter.To;

        #endregion
    }
}