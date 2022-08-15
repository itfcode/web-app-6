using ITFCodeWA.Core.Models.QueryFilters.Single;
using ITFCodeWA.Core.Services.FiltersHandlers.Single.Base;
using System.Linq.Expressions;

namespace ITFCodeWA.Core.Services.FiltersHandlers.Single
{
    public class NumericSingleFilterHandler : SingleFilterHandler<NumericSingleFilter, double>
    {
        #region Constructors

        public NumericSingleFilterHandler(NumericSingleFilter filter) : base(filter) { }

        #endregion

        #region Public Methods 

        public override Expression<Func<TEntity, bool>> Handle<TEntity>()
        {
            PrepareParams<TEntity>(out ParameterExpression item, out Expression property, out Expression? value);

            Expression body = _filter.MatchMode switch
            {
                NumericFilterMatchMode.LessThan => Expression.LessThan(property, value),
                NumericFilterMatchMode.LessThanOrEquals => Expression.LessThanOrEqual(property, value),
                NumericFilterMatchMode.GreaterThanOrEquals => Expression.GreaterThanOrEqual(property, value),
                NumericFilterMatchMode.GreaterThan => Expression.GreaterThan(property, value),
                NumericFilterMatchMode.Equals => Expression.Equal(property, value),
                _ => throw new ArgumentOutOfRangeException(),
            };

            return Expression.Lambda<Func<TEntity, bool>>(body, item);
        }

        #endregion
    }
}