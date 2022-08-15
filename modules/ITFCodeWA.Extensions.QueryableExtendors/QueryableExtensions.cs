using System.Linq.Expressions;

namespace ITFCodeWA.Extensions.QueryableExtendors
{
    public static class QueryableExtensions
    {
        public static IOrderedQueryable<TSource> SortBy<TSource, TKey>(this IQueryable<TSource> source, bool isAsc,
            params Expression<Func<TSource, TKey>>[] keySelectors)
        {
            ArgumentNullException.ThrowIfNull(source, nameof(source));
            ArgumentNullException.ThrowIfNull(keySelectors, nameof(source));

            var length = keySelectors.Length;

            if (keySelectors.Length == 0)
                throw new ArgumentOutOfRangeException(nameof(keySelectors), $"Argument '{nameof(keySelectors)}' shoud be not empty array.");

            var ordered = isAsc ? source.OrderBy(keySelectors[0]) : source.OrderByDescending(keySelectors[0]);

            for (int i = 1; i < length; i++)
                ordered = isAsc ? ordered.ThenBy(keySelectors[i]) : ordered.ThenByDescending(keySelectors[i]);

            return ordered;
        }
    }
}