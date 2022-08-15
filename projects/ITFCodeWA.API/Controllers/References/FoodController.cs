using ITFCodeWA.API.Constants;
using ITFCodeWA.Core.API.Controllers;
using ITFCodeWA.Core.Services.Operating.Interfaces;
using ITFCodeWA.Models.References;
using ITFCodeWA.Services.DataServices.References.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using static ITFCodeWA.API.Constants.SwaggerConfiguration.FoodController;

namespace ITFCodeWA.API.Controllers.References
{
    //[Route("api/[controller]")]
    [Route(ApiRoutes.FOODS)]
    [SwaggerTag(description: TAG_DESCRIPTION)]
    [ApiController]
    public class FoodController : ReferenceApiController<IFoodDataService, FoodModel>
    {
        #region Constructors

        public FoodController(ILogger<FoodController> logger, ICurrentUserService currentUserService, IFoodDataService dataService) :
            base(logger, currentUserService, dataService)
        { }

        #endregion

        #region Reading Methods 

        [SwaggerResponse(StatusCodes.Status200OK, GET_RESPONSE_DESCRIPTION, typeof(string))]
        public override async Task<IActionResult> GetAsync(int id, CancellationToken cancellationToken = default)
            => await base.GetAsync(id, cancellationToken);

        #endregion

        #region Writting Methods 

        [SwaggerResponse(StatusCodes.Status200OK, POST_RESPONSE_DESCRIPTION, typeof(FoodModel))]
        public override async Task<IActionResult> PostAsync([FromBody] FoodModel model,
                CancellationToken cancellationToken = default)
            => await base.PostAsync(model, cancellationToken);

        [SwaggerResponse(StatusCodes.Status200OK, PUT_RESPONSE_DESCRIPTION, typeof(FoodModel))]
        public override async Task<IActionResult> PutAsync([FromRoute, SwaggerParameter(PUT_ID_PARAMTER_DESCRIPTION)] int id,
            [FromBody] FoodModel model, CancellationToken cancellationToken = default)
            => await base.PutAsync(id, model, cancellationToken);

        [SwaggerResponse(StatusCodes.Status200OK, DELETE_RESPONSE_DESCRIPTION)]
        public override async Task<IActionResult> DeleteAsync([FromRoute, SwaggerParameter(DELETE_ID_PARAMTER_DESCRIPTION)] int id, CancellationToken cancellationToken = default)
            => await base.DeleteAsync(id, cancellationToken);

        #endregion
    }
}