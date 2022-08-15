using ITFCodeWA.ClientMudBlazor.Services.Api.Base.Totals.Interfaces;

namespace ITFCodeWA.ClientMudBlazor.Services.Api.Base.Totals
{
    public abstract class ApiTotalService : ApiBaseService, IApiTotalService
    {
        #region Constructor

        public ApiTotalService(ItfHttpClient httpClient, string route) : base(httpClient, route) { }

        #endregion
    }
}