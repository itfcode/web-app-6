using ITFCodeWA.Core.API.Controllers.Base;
using ITFCodeWA.Core.Models.Common.Documents.Interfaces;
using ITFCodeWA.Core.Services.DataServices.Base.Interfaces;
using ITFCodeWA.Core.Services.Operating.Interfaces;
using Microsoft.Extensions.Logging;

namespace ITFCodeWA.Core.API.Controllers
{
    public abstract class DocumentApiController<TDataService, TModel> : ApiController<TDataService, TModel, Guid>
        where TDataService : class, IDocumentDataService<TModel>
        where TModel : class, IDocumentModel
    {
        #region Constructions 

        public DocumentApiController(ILogger<DocumentApiController<TDataService, TModel>> logger,
            ICurrentUserService currentUserService,
            TDataService dataService) : base(logger, currentUserService, dataService)
        {
        }

        #endregion
    }
}