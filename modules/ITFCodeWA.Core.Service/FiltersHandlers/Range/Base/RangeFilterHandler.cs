using ITFCodeWA.Core.Models.QueryFilters.Range.Base.Interfaces;
using ITFCodeWA.Core.Services.FiltersHandlers.Base;
using System.Linq.Expressions;
using System.Reflection;

namespace ITFCodeWA.Core.Services.FiltersHandlers.Range.Base
{
    public abstract class RangeFilterHandler<TFilter, TValue> : FilterHandler<TFilter>
        where TFilter : class, IQueryRangeFilter<TValue>
    {
        #region Constractor

        protected RangeFilterHandler(TFilter filter) : base(filter) { }

        #endregion

        #region Public Methods 

        public override Expression<Func<TEntity, bool>> Handle<TEntity>()
        {
            var item = Expression.Parameter(typeof(TEntity), "item");
            var value = Expression.Property(item, _filter.PropertyName);

            MethodInfo methodInfo;
            ConstantExpression list;
            if (value.Type == typeof(TValue?))
            {
                methodInfo = typeof(List<TValue?>).GetMethod("Contains", new Type[] { typeof(TValue?) });
                list = Expression.Constant(_filter.Values.Select(x => (TValue?)x).ToList());
            }
            else
            {
                methodInfo = typeof(List<TValue>).GetMethod("Contains", new Type[] { typeof(TValue) });
                list = Expression.Constant(_filter.Values);
            }

            var body = Expression.Call(list, methodInfo, value);

            // item => codes.Contains(item.Code)
            return Expression.Lambda<Func<TEntity, bool>>(body, item);
        }

        #endregion
    }
}