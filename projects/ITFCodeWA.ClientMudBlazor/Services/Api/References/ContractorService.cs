using ITFCodeWA.ClientMudBlazor.Services.Api.Base.References;
using ITFCodeWA.ClientMudBlazor.Services.Api.References.Interfaces;
using ITFCodeWA.Models.References;

namespace ITFCodeWA.ClientMudBlazor.Services.Api.References
{
    public class ContractorService : ApiReferenceService<ContractorModel>, IContractorService
    {
        #region Constractor

        public ContractorService(ItfHttpClient httpClient) : base(httpClient, ApiEndPoints.References.CONTRACTORS)
        {
        }

        #endregion
    }
}