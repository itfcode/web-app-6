using System.Collections.Generic;

namespace ITFCodeWA.Core.Models.QueryFilters.Interfaces
{
    public interface IQueryListFilter<T> : IQueryFilter
    {
        List<T> Values { get; init; }
    }
}