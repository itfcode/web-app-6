using ITFCodeWA.API.Constants;
using ITFCodeWA.Core.API.Controllers;
using ITFCodeWA.Core.Services.Operating.Interfaces;
using ITFCodeWA.Models.References;
using ITFCodeWA.Services.DataServices.References.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using static ITFCodeWA.API.Constants.SwaggerConfiguration.ExpenseGroups;

namespace ITFCodeWA.API.Controllers.References
{
    [Route(ApiRoutes.EXPENSE_GROUPS)]
    [SwaggerTag(description: TAG_DESCRIPTION)]
    [ApiController]
    public class ExpenseGroupController : ReferenceApiController<IExpenseGroupDataService, ExpenseGroupModel>
    {
        #region Constructors

        public ExpenseGroupController(ILogger<ExpenseGroupController> logger, ICurrentUserService currentUserService, IExpenseGroupDataService dataService) :
            base(logger, currentUserService, dataService)
        { }

        #endregion

        #region Reading Methods 

        [SwaggerResponse(StatusCodes.Status200OK, GET_RESPONSE_DESCRIPTION, typeof(ExpenseGroupModel))]
        public override async Task<IActionResult> GetAsync(int id, CancellationToken cancellationToken = default)
            => await base.GetAsync(id, cancellationToken);

        #endregion

        #region Writting Methods 

        [SwaggerResponse(StatusCodes.Status200OK, POST_RESPONSE_DESCRIPTION, typeof(ExpenseGroupModel))]
        public override async Task<IActionResult> PostAsync([FromBody] ExpenseGroupModel model,
                CancellationToken cancellationToken = default)
            => await base.PostAsync(model, cancellationToken);

        [SwaggerResponse(StatusCodes.Status200OK, PUT_RESPONSE_DESCRIPTION, typeof(ExpenseGroupModel))]
        public override async Task<IActionResult> PutAsync([FromRoute, SwaggerParameter(PUT_ID_PARAMTER_DESCRIPTION)] int id,
                [FromBody] ExpenseGroupModel model, CancellationToken cancellationToken = default)
            => await base.PutAsync(id, model, cancellationToken);

        [SwaggerResponse(StatusCodes.Status200OK, DELETE_RESPONSE_DESCRIPTION)]
        public override async Task<IActionResult> DeleteAsync([FromRoute, SwaggerParameter(DELETE_ID_PARAMTER_DESCRIPTION)] int id,
                CancellationToken cancellationToken = default)
            => await base.DeleteAsync(id, cancellationToken);

        #endregion
    }
}
