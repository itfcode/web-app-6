using Microsoft.AspNetCore.Mvc.Filters;

namespace ITFCodeWA.API.Filters.Resource.Base
{
    public abstract class AsyncResourceFilterBase : IAsyncResourceFilter
    {
        public virtual async Task OnResourceExecutionAsync(ResourceExecutingContext context, ResourceExecutionDelegate next)
        {
            await Task.Run(() => throw new NotImplementedException());
        }
    }
}