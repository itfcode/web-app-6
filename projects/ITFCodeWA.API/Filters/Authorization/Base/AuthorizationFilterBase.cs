using Microsoft.AspNetCore.Mvc.Filters;

namespace ITFCodeWA.API.Filters.Authorization.Base
{
    public abstract class AuthorizationFilterBase : IAuthorizationFilter
    {
        public virtual void OnAuthorization(AuthorizationFilterContext context)
        {
            throw new NotImplementedException();
        }
    }
}
