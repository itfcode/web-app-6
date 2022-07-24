namespace ITFCodeWA.Core.Extensions.EnumerableExtendors
{
    /// <summary>
    /// Extension Methods for Enumerable
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Sorts the elements of a sequence in ascending/descending order according to a key.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="source"></param>
        /// <param name="isAsc"></param>
        /// <param name="keySelectors"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static IOrderedEnumerable<T> SortBy<T, TKey>(this IEnumerable<T> source, bool isAsc,
            params Func<T, TKey>[] keySelectors)
        {
            ArgumentNullException.ThrowIfNull(source, nameof(source));
            ArgumentNullException.ThrowIfNull(keySelectors, nameof(keySelectors));

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
        /// <typeparam name="T">The type of the source.</typeparam>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="keys">The keys.</param>
        /// <param name="keySelector">The key selector.</param>
        /// <param name="count">The count.</param>
        /// <returns></returns>
        public static IEnumerable<T> CrossApply<T, TKey>(this IEnumerable<T> source, IEnumerable<TKey> keys,
            Func<T, TKey> keySelector, int count = 1)
        {
            ArgumentNullException.ThrowIfNull(source, nameof(source));
            ArgumentNullException.ThrowIfNull(keys, nameof(keys));
            ArgumentNullException.ThrowIfNull(keySelector, nameof(keySelector));

            var items = Enumerable.Empty<T>();

            foreach (TKey key in keys)
            {
                items = items.Union(source.Where(x => keySelector(x).Equals(key)).Take(count));
            }

            return items;
        }

        /// <summary>
        /// Appends values to the end of the sequence.
        /// </summary>
        /// <typeparam name="T">The type of the elements of source</typeparam>
        /// <param name="source"> A sequence of values</param>
        /// <param name="element0">The value to append to source</param>
        /// <param name="element1">The value to append to source</param>
        /// <param name="elements">The value to append to source</param>
        /// <returns>A new sequence that ends with added elements</returns>
        public static IEnumerable<T> Append<T>(this IEnumerable<T> source, T element0, T element1, params T[] elements) 
        {
            ArgumentNullException.ThrowIfNull(source, nameof(source));

            return source.Append(element0)
                .Append(element1)
                .Concat(elements);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="element0"></param>
        /// <param name="element1"></param>
        /// <param name="elements"></param>
        /// <exception cref="System.ArgumentNullException">Throws when source is null</exception>
        /// <returns></returns>
        public static IEnumerable<T> Prepend<T>(this IEnumerable<T> source, T element0, T element1, params T[] elements) 
        {
            ArgumentNullException.ThrowIfNull(source, nameof(source));

            return elements.Prepend(element0)
                .Prepend(element1)
                .Reverse()
                .Concat(source);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static IReadOnlyList<T> ToReadOnlyList<T>(this IEnumerable<T> source) => source.ToList().AsReadOnly();

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="separator"></param>
        /// <returns></returns>
        public static string JoinToSting<T>(this IEnumerable<T> source, string separator = ",")
        {
            ArgumentNullException.ThrowIfNull(source, nameof(source));
            ArgumentNullException.ThrowIfNull(separator, nameof(separator));

            return string.Join(separator, source);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <param name="others"></param>
        /// <returns></returns>
        public static IEnumerable<T> Concat<T>(this IEnumerable<T> first, IEnumerable<T> second, IEnumerable<T> third, params IEnumerable<T>[] others)
        {
            ArgumentNullException.ThrowIfNull(first, nameof(first));
            ArgumentNullException.ThrowIfNull(second, nameof(second));
            ArgumentNullException.ThrowIfNull(third, nameof(third));

            var res = first.Concat(second).Concat(third);

            foreach (var item in others)
                res = res.Concat(item);

            return res;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <param name="others"></param>
        /// <returns></returns>
        public static IEnumerable<T> Union<T>(this IEnumerable<T> first, IEnumerable<T> second, IEnumerable<T> third, params IEnumerable<T>[] others)
        {
            ArgumentNullException.ThrowIfNull(first, nameof(first));
            ArgumentNullException.ThrowIfNull(second, nameof(second));
            ArgumentNullException.ThrowIfNull(third, nameof(third));

            var res = first.Union(second).Union(third);

            foreach (var item in others)
                res = res.Union(item);

            return res;
        }
    }
}