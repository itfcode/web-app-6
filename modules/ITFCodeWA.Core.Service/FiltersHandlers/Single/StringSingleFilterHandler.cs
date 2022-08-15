using ITFCodeWA.Core.Models.QueryFilters.Single;
using ITFCodeWA.Core.Services.FiltersHandlers.Single.Base;
using System.Linq.Expressions;
using System.Net;

namespace ITFCodeWA.Core.Services.FiltersHandlers.Single
{
    public class StringSingleFilterHandler : SingleFilterHandler<StringSingleFilter, string>
    {

        #region Constructors 

        public StringSingleFilterHandler(StringSingleFilter filter) : base(filter) { }

        #endregion

        #region Public Methods 

        public override Expression<Func<TEntity, bool>> Handle<TEntity>()
        {
            var item = Expression.Parameter(typeof(TEntity), "item");
            var property = Expression.Call(GetProperty(item, _filter.PropertyName), "ToUpper", null);
            var value = Expression.Constant(WebUtility.UrlDecode(_filter.Value.ToUpperInvariant()));

            if (_filter.MatchMode == StringFilterMatchMode.Contains)
            {
                var isNotNullExpression = Expression.NotEqual(property, Expression.Constant(null));
                var checkContainsExpression = Expression.Call(property, "Contains", null, value);
                var notNullAndContainsExpression = Expression.AndAlso(isNotNullExpression, checkContainsExpression);

                return Expression.Lambda<Func<TEntity, bool>>(notNullAndContainsExpression, item);
            }

            string methodName = _filter.MatchMode switch
            {
                StringFilterMatchMode.StartsWith => "StartsWith",
                StringFilterMatchMode.EndsWith => "EndsWith",
                StringFilterMatchMode.Equals => "Equals",
                _ => throw new ArgumentOutOfRangeException(),
            };

            var method = typeof(string).GetMethod(methodName, new Type[] { typeof(string) });
            var body = Expression.Call(property, method, value);

            return Expression.Lambda<Func<TEntity, bool>>(body, item);
        }

        #endregion
    }
}