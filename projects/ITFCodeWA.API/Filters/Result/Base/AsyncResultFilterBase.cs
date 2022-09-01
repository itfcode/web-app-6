using Microsoft.AspNetCore.Mvc.Filters;

namespace ITFCodeWA.API.Filters.Result.Base
{
    public abstract class AsyncResultFilterBase : IAsyncResultFilter
    {
        public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            await Task.Run(() => throw new NotImplementedException());
        }
    }
}