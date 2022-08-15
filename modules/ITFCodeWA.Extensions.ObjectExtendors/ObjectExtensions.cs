using System.Reflection;

namespace ITFCodeWA.Extensions.ObjectExtendors
{
    public static class ObjectExtensions
    {
        public static T AddTo<T>(this T self, ICollection<T> collection)
        {
            ArgumentNullException.ThrowIfNull(collection, nameof(collection));

            collection.Add(self);

            return self;
        }

        public static T AddTo<T>(this T self, ICollection<T> collection0, ICollection<T> collection1, params ICollection<T>[] collections)
        {
            ArgumentNullException.ThrowIfNull(collection0, nameof(collection1));
            ArgumentNullException.ThrowIfNull(collection1, nameof(collection1));

            if (collections.Any(x => x is null))
                throw new ArgumentException();

            foreach (var collection in collections.Concat(new ICollection<T>[] { collection0, collection1 }))
                collection.Add(self);

            return self;
        }

        public static T RemoveFrom<T>(this T self, ICollection<T> collection)
        {
            ArgumentNullException.ThrowIfNull(collection, nameof(collection));

            collection.Remove(self);

            return self;
        }

        public static T RemoveFrom<T>(this T self, ICollection<T> collection0, ICollection<T> collection1, params ICollection<T>[] collections)
        {
            ArgumentNullException.ThrowIfNull(collection0, nameof(collection0));
            ArgumentNullException.ThrowIfNull(collection1, nameof(collection1));

            if (collections.Any(x => x is null))
                throw new ArgumentException();

            foreach (var collection in collections.Concat(new ICollection<T>[] { collection0, collection1 }))
                collection.Remove(self);

            return self;
        }

        public static TResult GetTry<TSelf, TResult>(this TSelf self, Func<TSelf, TResult> func, TResult onFailedValue, bool throwIfNull = false)
            where TSelf : class
        {
            if (throwIfNull) ArgumentNullException.ThrowIfNull(self, nameof(self));

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
            ArgumentNullException.ThrowIfNull(self, nameof(self));

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