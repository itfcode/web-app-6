using ITFCodeWA.Core.Models;
using ITFCodeWA.Core.Models.Common.Base.Interfaces;
using ITFCodeWA.Core.Models.QueryFilters;

namespace ITFCodeWA.ClientMudBlazor.Services.Api.Base.Interfaces
{
    public interface IApiEntityReadService<TModel, TKey> 
        where TModel : class, IModel<TKey> 
        where TKey : IComparable
    {
        Task<TModel> GetByIdAsync(TKey id, CancellationToken cancellationToken = default);
        Task<PageResult<TModel>> GetPageAsync(QueryOptions queryOptions = default!, CancellationToken cancellationToken = default!);
    }
}