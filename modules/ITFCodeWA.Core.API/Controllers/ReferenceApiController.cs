using ITFCodeWA.Core.API.Controllers.Base;
using ITFCodeWA.Core.Models.Common.References.Interfaces;
using ITFCodeWA.Core.Services.DataServices.Base.Interfaces;
using ITFCodeWA.Core.Services.Operating.Interfaces;
using Microsoft.Extensions.Logging;

namespace ITFCodeWA.Core.API.Controllers
{
    public abstract class ReferenceApiController<TDataService, TModel> : ApiController<TDataService, TModel, int>
        where TDataService : class, IReferenceDataService<TModel>
        where TModel : class, IReferenceModel
    {
        #region Constructions 

        public ReferenceApiController(ILogger<ReferenceApiController<TDataService, TModel>> logger,
            ICurrentUserService currentUserService,
            TDataService dataService) : base(logger, currentUserService, dataService)
        {
        }

        #endregion
    }
}