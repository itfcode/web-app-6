using ITFCodeWA.API.Constants;
using ITFCodeWA.Core.API.Controllers;
using ITFCodeWA.Core.Services.Operating.Interfaces;
using ITFCodeWA.Services.TotalServices.Health.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using static ITFCodeWA.API.Constants.SwaggerConfiguration.FoodController;

namespace ITFCodeWA.API.Controllers.Totals
{
    [Route(ApiRoutes.WEIGHT_TOTALS)]
    [SwaggerTag(description: TAG_DESCRIPTION)]
    [ApiController]
    public class WeightTotalController : TotalApiController<IWeightTotalService>
    {
        #region Constructors

        public WeightTotalController(ILogger<WeightTotalController> logger, ICurrentUserService currentUserService, IWeightTotalService totalService) :
            base(logger, currentUserService, totalService)
        { }

        #endregion

        #region Reading Methods 

        [HttpGet("person/{personId}")]
        [SwaggerResponse(StatusCodes.Status200OK, GET_RESPONSE_DESCRIPTION, typeof(string))]
        public virtual async Task<IActionResult> GetPersonTotalsAsync(int personId, CancellationToken cancellationToken = default)
        {
            return Ok(await _totalService.GetPersonTotalsAsync(personId, cancellationToken));
        }

        #endregion
    }
}