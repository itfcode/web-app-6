using Microsoft.AspNetCore.Mvc.Filters;

namespace ITFCodeWA.API.Filters.Exception.Base
{
    public abstract class AsyncExceptionFilterBase : IAsyncExceptionFilter
    {
        public async Task OnExceptionAsync(ExceptionContext context)
        {
            await Task.Run(() => throw new NotImplementedException());
        }
    }
}
