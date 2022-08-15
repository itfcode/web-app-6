using ITFCodeWA.Core.Models.QueryFilters.Base.Interfaces;

namespace ITFCodeWA.Core.Models.QueryFilters.Diapason.Base.Intrefaces
{
    public interface IQueryDiapasonFilter<T> : IQueryFilter
    {
        T From { get; init; }

        T To { get; init; }
    }
}