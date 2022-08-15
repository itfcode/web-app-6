using ITFCodeWA.Models.Totals.Weight;
using ITFCodeWA.Services.TotalServices.Base.Interfaces;

namespace ITFCodeWA.Services.TotalServices.Health.Interfaces
{
    public interface IWeightTotalService : ITotalService
    {
        Task<PersonWeightTotalsModel> GetPersonTotalsAsync(int personId, CancellationToken cancellationToken = default);
    }
}