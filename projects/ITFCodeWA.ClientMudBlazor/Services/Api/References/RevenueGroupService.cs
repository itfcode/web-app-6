using ITFCodeWA.ClientMudBlazor.Services.Api.Base.References;
using ITFCodeWA.ClientMudBlazor.Services.Api.References.Interfaces;
using ITFCodeWA.Models.References;

namespace ITFCodeWA.ClientMudBlazor.Services.Api.References
{
    public class RevenueGroupService : ApiReferenceService<RevenueGroupModel>, IRevenueGroupService
    {
        #region Constractor

        public RevenueGroupService(ItfHttpClient httpClient) : base(httpClient, ApiEndPoints.References.REVENUE_GROUPS)
        {
        }

        #endregion
    }
}