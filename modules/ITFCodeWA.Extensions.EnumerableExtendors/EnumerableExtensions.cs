namespace ITFCodeWA.Core.Extensions.EnumerableExtendors
{
    public static class EnumerableExtensions
    {
        public static IOrderedEnumerable<TSource> SortBy<TSource, TKey>(this IEnumerable<TSource> source, bool isAsc,
            params Func<TSource, TKey>[] keySelectors)
        {
            ArgumentNullException.ThrowIfNull(source);
            ArgumentNullException.ThrowIfNull(keySelectors);

            var length = keySelectors.Length;

            if (keySelectors.Length == 0)
                throw new ArgumentOutOfRangeException(nameof(keySelectors), $"Argument '{nameof(keySelectors)}' shoud be not empty array.");

            var ordered = isAsc ? source.OrderBy(keySelectors[0]) : source.OrderByDescending(keySelectors[0]);

            for (int i = 1; i < length; i++)
                ordered = isAsc ? ordered.ThenBy(keySelectors[i]) : ordered.ThenByDescending(keySelectors[i]);

            return ordered;
        }

        /// <summary>
        /// Like CROSS APPLY in MS SQL.
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="keys">The keys.</param>
        /// <param name="keySelector">The key selector.</param>
        /// <param name="count">The count.</param>
        /// <returns></returns>
        public static IEnumerable<TSource> CrossApply<TSource, TKey>(this IEnumerable<TSource> source, IEnumerable<TKey> keys,
            Func<TSource, TKey> keySelector, int count = 1)
        {
            ArgumentNullException.ThrowIfNull(source);
            ArgumentNullException.ThrowIfNull(keys);
            ArgumentNullException.ThrowIfNull(keySelector);

            var items = Enumerable.Empty<TSource>();

            foreach (TKey key in keys)
            {
                items = items.Union(source.Where(x => keySelector(x).Equals(key)).Take(count));
            }

            return items;
        }

        public static IReadOnlyList<T> ToReadOnlyList<T>(this IEnumerable<T> source) => source.ToList().AsReadOnly();

        public static string JoinToSting<T>(this IEnumerable<T> source, string separator = ",")
        {
            ArgumentNullException.ThrowIfNull(source);
            ArgumentNullException.ThrowIfNull(separator);

            return string.Join(separator, source);
        }
    }
}