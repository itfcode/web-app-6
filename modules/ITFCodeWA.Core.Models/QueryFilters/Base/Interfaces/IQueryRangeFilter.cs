namespace ITFCodeWA.Core.Models.QueryFilters.Interfaces
{
    public interface IQueryRangeFilter<T> : IQueryFilter
    {
        T From { get; init; }

        T To { get; init; }
    }
}