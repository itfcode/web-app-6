using Microsoft.AspNetCore.Mvc.Filters;

namespace ITFCodeWA.API.Filters.Authorization.Base
{
    public abstract class AsyncAuthorizationFilterBase : IAsyncAuthorizationFilter
    {
        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            await Task.Run(() => throw new NotImplementedException());
        }
    }
}
