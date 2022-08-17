using ITFCodeWA.Core.Models.Common.Base.Interfaces;
using ITFCodeWA.Core.Services.DataServices.Base.Interfaces;
using ITFCodeWA.Core.Services.Operating.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ITFCodeWA.Core.API.Controllers.Base
{
    public abstract class ApiController<TDataService, TModel, TKey> : ReadOnlyApiController<TDataService, TModel, TKey>
        where TKey : IComparable
        where TDataService : class, IDataService<TModel, TKey>
        where TModel : class, IModel<TKey>
    {
        #region Constructions 

        public ApiController(ILogger<ApiController<TDataService, TModel, TKey>> logger,
            ICurrentUserService currentUserService,
            TDataService dataService) : base(logger, currentUserService, dataService)
        {
        }

        #endregion

        #region Write Methods 

        [HttpPost]
        public virtual async Task<IActionResult> PostAsync([FromBody] TModel model, CancellationToken cancellationToken = default)
        {
            return Ok(await _dataService.CreateAsync(model, cancellationToken));
        }

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> PutAsync([FromRoute] TKey id, [FromBody] TModel model, CancellationToken cancellationToken = default)
        {
            return Ok(await _dataService.UpdateAsync(model, cancellationToken));
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> DeleteAsync([FromRoute] TKey id, CancellationToken cancellationToken = default)
        {
            await _dataService.DeleteAsync(id, cancellationToken);
            return Ok();
        }

        #endregion

    }
}