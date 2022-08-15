using ITFCodeWA.Core.Models.QueryFilters.Base.Interfaces;

namespace ITFCodeWA.Core.Models.QueryFilters.Range.Base.Interfaces
{
    public interface IQueryRangeFilter<T> : IQueryFilter
    {
        List<T> Values { get; init; }
    }
}