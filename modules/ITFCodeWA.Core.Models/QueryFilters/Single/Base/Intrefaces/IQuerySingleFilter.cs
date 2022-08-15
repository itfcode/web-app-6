using ITFCodeWA.Core.Models.QueryFilters.Base.Interfaces;

namespace ITFCodeWA.Core.Models.QueryFilters.Single.Base.Intrefaces
{
    public interface IQuerySingleFilter<T> : IQueryFilter
    {
        T Value { get; init; }
    }
}
