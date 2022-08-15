namespace ITFCodeWA.Extensions.DictionaryExtendors
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    public static class DictionaryExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TDictionary"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="source"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TDictionary Append<TDictionary, TKey, TValue>(this TDictionary source, TKey key, TValue value) where TDictionary : IDictionary<TKey, TValue>
        {
            ArgumentNullException.ThrowIfNull(source, nameof(source));
            ArgumentNullException.ThrowIfNull(key, nameof(key));

            source.Add(key, value);

            return source;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TDictionary"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="source"></param>
        /// <param name="keys"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static TDictionary Append<TDictionary, TKey, TValue>(this TDictionary source, IEnumerable<TKey> keys, IEnumerable<TValue> values) where TDictionary : IDictionary<TKey, TValue>
        {
            ArgumentNullException.ThrowIfNull(source, nameof(source));
            ArgumentNullException.ThrowIfNull(keys, nameof(source));
            ArgumentNullException.ThrowIfNull(values, nameof(source));

            var arrKeys = keys.ToArray();
            var arrValues = values.ToArray();

            if (arrKeys.Length != arrValues.Length)
                throw new ArgumentException($"Item count of Keys should be equalized to item count of Values");

            for (int i = 0; i < arrKeys.Length; i++)
                source.Append(arrKeys[i], arrValues[i]);

            return source;
        }
    }
}