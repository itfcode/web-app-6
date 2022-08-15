using ITFCodeWA.Core.Models.Common.Base.Interfaces;

namespace ITFCodeWA.Core.Services.DataServices.Base.Interfaces
{
    public interface IDataService<TEntityModel, TKey> : IReadOnlyDataService<TEntityModel, TKey>
        where TEntityModel : class, IModel<TKey>
        where TKey : IComparable
    {
        Task<TEntityModel> CreateAsync(TEntityModel model, CancellationToken cancellationToken = default);
        Task CreateRangeAsync(IEnumerable< TEntityModel> models, CancellationToken cancellationToken = default);
        
        Task<TEntityModel> UpdateAsync(TEntityModel model, CancellationToken cancellationToken = default);
        Task UpdateRangeAsync(IEnumerable<TEntityModel> models, CancellationToken cancellationToken = default);

        Task DeleteAsync(TKey id, CancellationToken cancellationToken = default);
        Task DeleteRangeAsync(IEnumerable<TKey> ids, CancellationToken cancellationToken = default);
    }
}