using System.Reflection;

namespace ITFCodeWA.Extensions.ObjectExtendors
{
    public static class ObjectExtensions
    {
        public static TResult TryGet<TSource, TResult>(this TSource self, Func<TSource, TResult> func, TResult onFailedValue, bool throwIfNull = false)
            where TSource : class
        {
            if (throwIfNull) ArgumentNullException.ThrowIfNull(self);

            TResult result;

            try
            {
                result = func(self) ?? onFailedValue;
            }
            catch
            {
                result = onFailedValue;
            }

            return result;
        }

        public static TSelf Exec<TSelf>(this TSelf self, Action<TSelf> action) where TSelf : class
        {
            try
            {
                action(self);
            }
            catch (Exception)
            {
                throw;
            }

            return self;
        }

        public static TSelf Set<TSelf, TType>(this TSelf self, string propName, TType propValue) where TSelf : class
        {
            ArgumentNullException.ThrowIfNull(self);

            var propInfo = self.GetType().GetProperty(propName, BindingFlags.Instance | BindingFlags.Public);

            if (propInfo is null)
                throw new NullReferenceException($"Property '{propName}' not found for type '{self.GetType().Name}'");

            try
            {
                propInfo.SetValue(self, propValue, null);
            }
            catch (Exception ex)
            {
                throw new Exception($"Extension method 'Set': Property name '{propName}' - can not set value '{propValue}'", ex);
            }

            return self;
        }
    }
}