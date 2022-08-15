using ITFCodeWA.ClientMudBlazor.Services.Api.Base.References;
using ITFCodeWA.ClientMudBlazor.Services.Api.References.Interfaces;
using ITFCodeWA.Models.References;

namespace ITFCodeWA.ClientMudBlazor.Services.Api.References
{
    public class RevenueItemService : ApiReferenceService<RevenueItemModel>, IRevenueItemService
    {
        #region Constractor

        public RevenueItemService(ItfHttpClient httpClient) : base(httpClient, ApiEndPoints.References.REVENUE_ITEMS)
        {
        }

        #endregion
    }
}