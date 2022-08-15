using ITFCodeWA.API.Constants;
using ITFCodeWA.Core.API.Controllers;
using ITFCodeWA.Core.Services.Operating.Interfaces;
using ITFCodeWA.Models.References;
using ITFCodeWA.Services.DataServices.References.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ITFCodeWA.API.Controllers.References
{
    [Route(ApiRoutes.CONTRACTORS)]
    [SwaggerTag(description: "Справочник <b>Контрагенты / Юридические лица</b>")]
    [ApiController]
    public class ContractorController : ReferenceApiController<IContractorDataService, ContractorModel>
    {
        #region Constructors

        public ContractorController(ILogger<ContractorController> logger, ICurrentUserService currentUserService, IContractorDataService dataService) :
            base(logger, currentUserService, dataService)
        { }

        #endregion

        #region Read Methods 

        [SwaggerResponse(StatusCodes.Status200OK, "Информация о контрагенте / юридическом лице ", typeof(ContractorModel))]
        public override async Task<IActionResult> GetAsync(int id, CancellationToken cancellationToken = default)
            => await base.GetAsync(id, cancellationToken);

        #endregion
    }
}
