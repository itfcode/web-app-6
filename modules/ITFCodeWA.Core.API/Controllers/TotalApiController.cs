using ITFCodeWA.Core.Services.Operating.Interfaces;
using ITFCodeWA.Services.TotalServices.Base.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ITFCodeWA.Core.API.Controllers
{
    public abstract class TotalApiController<TTotalService> : ControllerBase
        where TTotalService : class, ITotalService
    {
        #region Private & Protected Fields 

        protected readonly ILogger<TotalApiController<TTotalService>> _logger;
        protected readonly ICurrentUserService _currentUserService;
        protected readonly TTotalService _totalService;

        #endregion

        #region Constructions 

        public TotalApiController(ILogger<TotalApiController<TTotalService>> logger,
            ICurrentUserService currentUserService,
            TTotalService totalService)
        {
            _logger = logger;
            _currentUserService = currentUserService;
            _totalService = totalService;
        }

        #endregion

        #region Read Methods 

        #endregion

        #region Private & Protected Methods 

        protected void LogMethodStart(string methodName, string? methodParams = null)
            => _logger.Log(LogLevel.Information, $"Method start: {GetType().Name}.{methodName}:({methodParams ?? string.Empty})");

        #endregion

    }
}