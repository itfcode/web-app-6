using ITFCodeWA.ClientMudBlazor.Services.Api.Base.Totals;
using ITFCodeWA.ClientMudBlazor.Services.Api.Totals.Interfaces;
using ITFCodeWA.Models.Totals.Weight;

namespace ITFCodeWA.ClientMudBlazor.Services.Api.Totals
{
    public class WeightTotalService : ApiTotalService, IWeightTotalService
    {
        #region Constructors 

        public WeightTotalService(ItfHttpClient httpClient) : base(httpClient, ApiEndPoints.Totals.WEIGHT_TOTALS) { }

        #endregion

        #region Public Methods 

        public async Task<PersonWeightTotalsModel> GetPersonTotalsAsync(int personId, CancellationToken cancellationToken = default)
            => await GetAsync<PersonWeightTotalsModel>($"{_route}/person/{personId}");

        #endregion

    }
}