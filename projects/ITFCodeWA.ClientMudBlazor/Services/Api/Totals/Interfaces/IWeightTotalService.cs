using ITFCodeWA.Models.Totals.Weight;

namespace ITFCodeWA.ClientMudBlazor.Services.Api.Totals.Interfaces
{
    public interface IWeightTotalService
    {
        Task<PersonWeightTotalsModel> GetPersonTotalsAsync(int personId, CancellationToken cancellationToken = default);
    }
}