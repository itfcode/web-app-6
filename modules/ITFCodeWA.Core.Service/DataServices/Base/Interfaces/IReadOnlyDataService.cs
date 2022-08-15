using ITFCodeWA.Core.Models;
using ITFCodeWA.Core.Models.Common.Base.Interfaces;
using ITFCodeWA.Core.Models.QueryFilters;

namespace ITFCodeWA.Core.Services.DataServices.Base.Interfaces
{
    public interface IReadOnlyDataService<TEntityModel, TKey> : IDisposable
        where TEntityModel : class, IModel<TKey>
        where TKey : IComparable
    {
        Task<bool> ExistsAsync(TKey id, CancellationToken cancellationToken = default);
        Task<TEntityModel> GetByIdAsync(TKey id, CancellationToken cancellationToken = default);
        Task<PageResult<TEntityModel>> GetPageAsync(QueryOptions queryOptions, CancellationToken cancellationToken = default);
        Task<object> GetFilterValues(string columnName, QueryOptions queryOptions, CancellationToken cancellationToken = default);
    }
}