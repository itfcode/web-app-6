using ITFCodeWA.Core.Models.Common.References.Interfaces;

namespace ITFCodeWA.Core.Services.DataServices.Base.Interfaces
{
    public interface IReferenceReadOnlyDataService<TEntityModel> : IReadOnlyDataService<TEntityModel, int>
        where TEntityModel : class, IReferenceModel
    {
        Task<TEntityModel> GetByNameAsync(string name, CancellationToken cancellationToken = default);
        Task<IList<TEntityModel>> GetAllByNameAsync(string name, CancellationToken cancellationToken = default);
    }
}