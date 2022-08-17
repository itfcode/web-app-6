using ITFCodeWA.Core.Models.Common.Base.Interfaces;

namespace ITFCodeWA.ClientMudBlazor.Services.Api.Base.Interfaces
{
    public interface IApiEntityCrudService<TModel, TKey> : IApiEntityReadService<TModel, TKey>
        where TModel : class, IModel<TKey>
        where TKey : IComparable
    {
        Task<TModel> SaveAsync(TModel model, CancellationToken cancellationToken = default);
        Task<TModel> AddAsync(TModel model, CancellationToken cancellationToken = default);
        Task<TModel> UpdateAsync(TModel model, CancellationToken cancellationToken = default);
        Task<bool> DeleteAsync(TKey id, CancellationToken cancellationToken = default);
    }
}