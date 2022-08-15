using ITFCodeWA.Core.Models.QueryFilters.Base.Interfaces;
using ITFCodeWA.Core.Services.Helpers;
using System.Linq.Expressions;

namespace ITFCodeWA.Core.Services.FiltersHandlers.Base
{
    public abstract class FilterHandler<TFilter> where TFilter : class, IQueryFilter
    {
        #region Private & Protected Fields

        protected readonly TFilter _filter;

        #endregion

        #region Constructors

        public FilterHandler(TFilter filter)
        {
            _filter = filter;
        }

        #endregion

        #region Public Abstract Methods 

        public abstract Expression<Func<TEntity, bool>> Handle<TEntity>();

        #endregion

        #region Protected Virtual Methods 

        protected virtual Expression GetValue<T>(T value, Type propertyType)
        {
            ArgumentValidator.ValidateNull((value, nameof(value)), (propertyType, nameof(propertyType)));

            return Expression.Convert(Expression.Constant(value), propertyType);
        }

        protected virtual Expression GetProperty(ParameterExpression item, string propertyName)
        {
            ArgumentValidator.ValidateNull((item, nameof(item)), (propertyName, nameof(propertyName)));
            ArgumentValidator.ValidateEmpty((propertyName, nameof(propertyName)));

            var parts = propertyName.Split('.');
            return parts.Aggregate<string, Expression>(item, Expression.Property);
        }

        #endregion
    }
}
