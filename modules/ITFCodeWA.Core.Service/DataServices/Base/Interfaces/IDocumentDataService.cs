using ITFCodeWA.Core.Models.Common.Documents.Interfaces;

namespace ITFCodeWA.Core.Services.DataServices.Base.Interfaces
{
    public interface IDocumentDataService<TEntityModel> : IDataService<TEntityModel, Guid>
        where TEntityModel : class, IDocumentModel
    {
        Task<TEntityModel> GetByNumberAsync(int number, CancellationToken cancellationToken = default);
    }
}