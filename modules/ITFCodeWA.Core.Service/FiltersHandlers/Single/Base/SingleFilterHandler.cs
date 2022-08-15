using ITFCodeWA.Core.Models.QueryFilters.Single.Base.Intrefaces;
using ITFCodeWA.Core.Services.FiltersHandlers.Base;
using System.Linq.Expressions;

namespace ITFCodeWA.Core.Services.FiltersHandlers.Single.Base
{
    public abstract class SingleFilterHandler<TFilter, TValue> : FilterHandler<TFilter>
        where TFilter : class, IQuerySingleFilter<TValue>
    {
        #region Constractor

        protected SingleFilterHandler(TFilter filter) : base(filter) { }

        #endregion

        #region Public Methods 

        public override Expression<Func<TEntity, bool>> Handle<TEntity>()
        {
            PrepareParams<TEntity>(out ParameterExpression item, out Expression property, out Expression? value);

            return Expression.Lambda<Func<TEntity, bool>>(Expression.Equal(property, value), item);
        }

        #endregion

        #region Private & Protected Methods 
        protected void PrepareParams<T>(out ParameterExpression item, out Expression property, out Expression? value)
        {
            item = Expression.Parameter(typeof(T), "item");
            property = GetProperty(item, _filter.PropertyName);
            value = GetValue(_filter.Value, property.Type);
        }

        #endregion
    }
}