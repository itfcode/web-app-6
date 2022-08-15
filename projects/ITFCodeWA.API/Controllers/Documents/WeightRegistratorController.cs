using ITFCodeWA.API.Constants;
using ITFCodeWA.Core.API.Controllers;
using ITFCodeWA.Core.Services.Operating.Interfaces;
using ITFCodeWA.Models.Documents;
using ITFCodeWA.Services.DataServices.Documents.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using static ITFCodeWA.API.Constants.SwaggerConfiguration.Foods;

namespace ITFCodeWA.API.Controllers.Documents
{
    //[Route("api/[controller]")]
    [Route(ApiRoutes.WEIGHT_REGISTRATORS)]
    [SwaggerTag(description: TAG_DESCRIPTION)]
    [ApiController]
    public class WeightRegistratorController : DocumentApiController<IWeightRegistratorDataService, WeightRegistratorModel>
    {
        #region Constructors

        public WeightRegistratorController(ILogger<WeightRegistratorController> logger,
            ICurrentUserService currentUserService,
            IWeightRegistratorDataService dataService) : base(logger, currentUserService, dataService)
        { }

        #endregion

        #region Reading Methods 

        [SwaggerResponse(StatusCodes.Status200OK, GET_RESPONSE_DESCRIPTION, typeof(string))]
        public override async Task<IActionResult> GetAsync(Guid id, CancellationToken cancellationToken = default)
            => await base.GetAsync(id, cancellationToken);

        #endregion

        #region Writting Methods 

        [SwaggerResponse(StatusCodes.Status200OK, POST_RESPONSE_DESCRIPTION, typeof(WeightRegistratorModel))]
        public override async Task<IActionResult> PostAsync([FromBody] WeightRegistratorModel model,
                CancellationToken cancellationToken = default)
            => await base.PostAsync(model, cancellationToken);

        [SwaggerResponse(StatusCodes.Status200OK, PUT_RESPONSE_DESCRIPTION, typeof(WeightRegistratorModel))]
        public override async Task<IActionResult> PutAsync([FromRoute, SwaggerParameter(PUT_ID_PARAMTER_DESCRIPTION)] Guid id,
                [FromBody] WeightRegistratorModel model, CancellationToken cancellationToken = default)
            => await base.PutAsync(id, model, cancellationToken);

        [SwaggerResponse(StatusCodes.Status200OK, DELETE_RESPONSE_DESCRIPTION)]
        public override async Task<IActionResult> DeleteAsync([FromRoute, SwaggerParameter(DELETE_ID_PARAMTER_DESCRIPTION)] Guid id, 
                CancellationToken cancellationToken = default)
            => await base.DeleteAsync(id, cancellationToken);

        #endregion
    }
}