using ITFCodeWA.Core.Services.DataServices.Base.Interfaces;
using ITFCodeWA.Models.References;

namespace ITFCodeWA.Services.DataServices.References.Interfaces
{
    public interface IPersonDataService : IReferenceDataService<PersonModel>
    {
        Task<PersonModel> GetByUtrAsync(long utr, CancellationToken cancellationToken = default);
    }
}