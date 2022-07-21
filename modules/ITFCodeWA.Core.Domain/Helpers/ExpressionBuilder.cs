using System.Linq.Expressions;

namespace ITFCodeWA.Core.Domain.Helpers
{
    public static class ExpressionBuilder
    {
        public static Expression<Func<T, bool>> GenerateEqual<T>(string propertyName, object? propertyValue) where T : class
        {
            var parameter = Expression.Parameter(typeof(T), "p");
            var property = Expression.Property(parameter, propertyName);
            var constant = Expression.Constant(propertyValue);
            var expession = Expression.Equal(property, constant);

            return Expression.Lambda<Func<T, bool>>(expession, parameter);
        }
    }
}
