using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace ITFCodeWA.API.Filters.Authentication.Base
{
    public class AuthenticationFilterBase : FilterAttribute, IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            throw new NotImplementedException();
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            throw new NotImplementedException();
        }
    }
}