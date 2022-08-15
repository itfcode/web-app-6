using ITFCodeWA.ClientMudBlazor.Services.Api.Base.References;
using ITFCodeWA.ClientMudBlazor.Services.Api.References.Interfaces;
using ITFCodeWA.Models.References;

namespace ITFCodeWA.ClientMudBlazor.Services.Api.References
{
    public class CurrencyService : ApiReferenceService<CurrencyModel>, ICurrencyService
    {
        #region Constractor

        public CurrencyService(ItfHttpClient httpClient) : base(httpClient, ApiEndPoints.References.CURRENCIES)
        {
        }

        #endregion
    }
}