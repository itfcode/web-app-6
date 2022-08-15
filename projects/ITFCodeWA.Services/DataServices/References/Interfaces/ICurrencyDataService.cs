using ITFCodeWA.Core.Services.DataServices.Base.Interfaces;
using ITFCodeWA.Models.References;

namespace ITFCodeWA.Services.DataServices.References.Interfaces
{
    public interface ICurrencyDataService : IReferenceDataService<CurrencyModel>
    {
        Task<CurrencyModel> GetByCodeAsync(int code, CancellationToken cancellationToken = default);
    }
}