using ITFCodeWA.ClientMudBlazor.Services.Api.Base.Documents;
using ITFCodeWA.ClientMudBlazor.Services.Api.Documents.Interfaces;
using ITFCodeWA.Core.Models.Common.Base.Interfaces;
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

        public override async Task<WeightRegistratorModel> AddAsync(WeightRegistratorModel model, CancellationToken cancellationToken = default)
        {
            if (model.Id.Equals(Guid.Empty))
            { 
                var id = Guid.NewGuid();
                model.Id = id;
                foreach (var row in model.Rows)
                {
                    row.DocumentId = id;
                }
            }
            return await PostAsync<WeightRegistratorModel>(RouteAdd, model, cancellationToken);
        }
    }
}