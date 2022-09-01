using Microsoft.AspNetCore.Mvc.Filters;

namespace ITFCodeWA.API.Filters.Action.Base
{
    public abstract class AsyncActionFilterBase : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            await Task.Run(() => throw new NotImplementedException());
        }
    }
}
