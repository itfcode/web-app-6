using System.Linq.Expressions;

namespace ITFCodeWA.Core.Domain.Helpers
{
    public static class ExpressionFactory
    {
        #region Public Methods 

        public static Expression<Func<T, bool>> Equal<T>(string propertyName, object propertyValue) where T : class
            => GetComparisonMethod<T>(propertyName, propertyValue, ComparisonMethod.Equal);

        public static Expression<Func<T, bool>> LessThan<T>(string propertyName, object propertyValue) where T : class
            => GetComparisonMethod<T>(propertyName, propertyValue, ComparisonMethod.LessThan);

        public static Expression<Func<T, bool>> LessThanOrEquals<T>(string propertyName, object propertyValue) where T : class
            => GetComparisonMethod<T>(propertyName, propertyValue, ComparisonMethod.LessThanOrEqual);

        public static Expression<Func<T, bool>> GreaterThan<T>(string propertyName, object propertyValue) where T : class
            => GetComparisonMethod<T>(propertyName, propertyValue, ComparisonMethod.GreaterThan);

        public static Expression<Func<T, bool>> GreaterThanOrEquals<T>(string propertyName, object propertyValue) where T : class
            => GetComparisonMethod<T>(propertyName, propertyValue, ComparisonMethod.GreaterThanOrEqual);

        #endregion

        #region Private Methods 

        private static Expression<Func<T, bool>> GetComparisonMethod<T>(string propertyName, object propertyValue, ComparisonMethod comparisonMethod)
        {
            var parameter = Expression.Parameter(typeof(T), "p");
            var property = Expression.Property(parameter, propertyName);
            var constant = Expression.Constant(propertyValue);

            BinaryExpression expession;

            switch (comparisonMethod)
            {
                case ComparisonMethod.Equal:
                    expession = Expression.Equal(property, constant);
                    break;
                case ComparisonMethod.LessThan:
                    expession = Expression.LessThan(property, constant);
                    break;
                case ComparisonMethod.LessThanOrEqual:
                    expession = Expression.LessThanOrEqual(property, constant);
                    break;
                case ComparisonMethod.GreaterThan:
                    expession = Expression.GreaterThan(property, constant);
                    break;
                case ComparisonMethod.GreaterThanOrEqual:
                    expession = Expression.GreaterThanOrEqual(property, constant);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return Expression.Lambda<Func<T, bool>>(expession, parameter);
        }

        #endregion

        #region Additional Enum 

        private enum ComparisonMethod
        {
            Equal,
            LessThan,
            LessThanOrEqual,
            GreaterThan,
            GreaterThanOrEqual
        }

        #endregion
    }
}