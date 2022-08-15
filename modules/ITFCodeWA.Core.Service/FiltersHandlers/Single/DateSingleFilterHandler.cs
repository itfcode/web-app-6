using ITFCodeWA.Core.Models.QueryFilters.Single;
using ITFCodeWA.Core.Services.FiltersHandlers.Single.Base;
using System.Linq.Expressions;

namespace ITFCodeWA.Core.Services.FiltersHandlers.Single
{
    public class DateSingleFilterHandler : SingleFilterHandler<DateSingleFilter, DateTimeOffset>
    {
        #region Constructors

        public DateSingleFilterHandler(DateSingleFilter filter) : base(filter) { }

        #endregion

        #region Public Methods 

        public override Expression<Func<TEntity, bool>> Handle<TEntity>()
        {
            PrepareParams<TEntity>(out ParameterExpression item, out Expression property, out Expression? value);

            Expression body = _filter.MatchMode switch
            {
                DateFilterMatchMode.LessThan => Expression.LessThan(property, value),
                DateFilterMatchMode.LessThanOrEquals => Expression.LessThanOrEqual(property, value),
                DateFilterMatchMode.GreaterThanOrEquals => Expression.GreaterThanOrEqual(property, value),
                DateFilterMatchMode.GreaterThan => Expression.GreaterThan(property, value),
                DateFilterMatchMode.Equals => Expression.Equal(property, value),
                _ => throw new ArgumentOutOfRangeException(),
            };

            return Expression.Lambda<Func<TEntity, bool>>(body, item);
        }

        #endregion
    }
}
