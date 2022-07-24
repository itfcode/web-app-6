using System.Linq.Expressions;

namespace ITFCodeWA.Core.Domain.Helpers
{
    public static class ExpressionBuilder
    {
        public static Expression<Func<T, bool>> GenerateContains<T>(string propertyName, object? propertyValue) where T : class
            => throw new NotImplementedException();

        public static Expression<Func<T, bool>> GenerateInRange<T>(string propertyName, IEnumerable<object> propertyValues) where T : class
            => throw new NotImplementedException();

        public static Expression<Func<T, bool>> GenerateStartWith<T>(string propertyName, object propertyValue) where T : class
            => throw new NotImplementedException();

    }
}
