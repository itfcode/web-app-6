using ITFCodeWA.Core.Models.Common.Base.Interfaces;
using ITFCodeWA.Core.Models.QueryFilters;
using ITFCodeWA.Core.Services.DataServices.Base.Interfaces;
using ITFCodeWA.Core.Services.Operating.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ITFCodeWA.Core.API.Controllers.Base
{
    public abstract class ReadOnlyApiController<TDataService, TModel, TKey> : ControllerBase
        where TKey : IComparable
        where TDataService : class, IReadOnlyDataService<TModel, TKey>
        where TModel : class, IModel<TKey>
    {
        #region Private & Protected Fields 

        protected readonly ILogger<ReadOnlyApiController<TDataService, TModel, TKey>> _logger;
        protected readonly ICurrentUserService _currentUserService;
        protected readonly TDataService _dataService;

        #endregion

        #region Constructions 

        public ReadOnlyApiController(ILogger<ReadOnlyApiController<TDataService, TModel, TKey>> logger,
            ICurrentUserService currentUserService,
            TDataService dataService)
        {
            _logger = logger;
            _currentUserService = currentUserService;
            _dataService = dataService;
        }

        #endregion

        #region Read Methods 

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> GetAsync(TKey id, CancellationToken cancellationToken = default)
        {
            LogMethodStart("GetAsync");

            return Ok(await FindByIdAsync(id, $"Item not found (ID = {id})", true));
        }

        [HttpGet("page")]
        public virtual async Task<IActionResult> GetPageAsync([FromQuery] QueryOptions queryOptions, CancellationToken cancellationToken = default)
        {
            LogMethodStart("GetPageAsync");

            return Ok(await _dataService.GetPageAsync(queryOptions));
        }

        #endregion

        #region Private & Protected Methods 

        protected async Task<TModel> FindByIdAsync(TKey id, string message, bool throwIfNull = false)
        {
            var item = await _dataService.GetByIdAsync(id);

            if (item == null && throwIfNull)
                throw new Exception(message);

            return item;
        }

        protected void LogMethodStart(string methodName, string? methodParams = null)
            => _logger.Log(LogLevel.Information, $"Method start: {GetType().Name}.{methodName}:({methodParams ?? string.Empty})");

        #endregion

    }
}
