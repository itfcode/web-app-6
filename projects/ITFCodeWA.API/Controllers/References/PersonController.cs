using ITFCodeWA.API.Constants;
using ITFCodeWA.Core.API.Controllers;
using ITFCodeWA.Core.Models;
using ITFCodeWA.Core.Models.QueryFilters;
using ITFCodeWA.Core.Services.Operating.Interfaces;
using ITFCodeWA.Models.References;
using ITFCodeWA.Services.DataServices.References.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using static ITFCodeWA.API.Constants.SwaggerConfiguration.Persons;

namespace ITFCodeWA.API.Controllers.References
{
    [Route(ApiRoutes.PERSONS)]
    [SwaggerTag(description: TAG_DESCRIPTION)]
    [ApiController]
    public class PersonController : ReferenceApiController<IPersonDataService, PersonModel>
    {
        #region Constructors

        public PersonController(ILogger<PersonController> logger, ICurrentUserService currentUserService, IPersonDataService dataService) :
            base(logger, currentUserService, dataService)
        { }

        #endregion

        #region Read Methods 

        [SwaggerResponse(StatusCodes.Status200OK, GET_RESPONSE_DESCRIPTION, typeof(PersonModel))]
        public override async Task<IActionResult> GetAsync(int id, CancellationToken cancellationToken = default)
            => await base.GetAsync(id, cancellationToken);

        [SwaggerResponse(StatusCodes.Status200OK, GET_PAGE_RESPONSE_DESCRIPTION, typeof(PageResult<PersonModel>))]
        public override async Task<IActionResult> GetPageAsync([FromQuery] QueryOptions queryOptions, CancellationToken cancellationToken = default)
            => await base.GetPageAsync(queryOptions, cancellationToken);

        #endregion

        #region Write Methods

        [SwaggerResponse(StatusCodes.Status200OK, POST_RESPONSE_DESCRIPTION, typeof(PersonModel))]
        public override async Task<IActionResult> PostAsync([FromBody] PersonModel model, CancellationToken cancellationToken = default)
            => await base.PostAsync(model, cancellationToken);

        [SwaggerResponse(StatusCodes.Status200OK, PUT_RESPONSE_DESCRIPTION, typeof(PersonModel))]
        public override async Task<IActionResult> PutAsync([FromRoute, SwaggerParameter(PUT_ID_PARAMTER_DESCRIPTION)] int id,
            [FromBody] PersonModel model, CancellationToken cancellationToken = default)
            => await base.PutAsync(id, model, cancellationToken);

        [SwaggerResponse(StatusCodes.Status200OK, DELETE_RESPONSE_DESCRIPTION)]
        public override async Task<IActionResult> DeleteAsync([FromRoute, SwaggerParameter(DELETE_ID_PARAMTER_DESCRIPTION)] int id, CancellationToken cancellationToken = default)
            => await base.DeleteAsync(id, cancellationToken);

        #endregion
    }
}