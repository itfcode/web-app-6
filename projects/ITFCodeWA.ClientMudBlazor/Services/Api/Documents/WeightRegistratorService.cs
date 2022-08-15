using ITFCodeWA.ClientMudBlazor.Services.Api.Base.Documents;
using ITFCodeWA.ClientMudBlazor.Services.Api.Documents.Interfaces;
using ITFCodeWA.Models.Documents;

namespace ITFCodeWA.ClientMudBlazor.Services.Api.Documents
{
    public class WeightRegistratorService : ApiDocumentService<WeightRegistratorModel>, IWeightRegistratorService
    {
        #region Constractor

        public WeightRegistratorService(ItfHttpClient httpClient) : base(httpClient, ApiEndPoints.Documents.WEIGHT_REGISTRATORS)
        {
        }

        #endregion
    }
}