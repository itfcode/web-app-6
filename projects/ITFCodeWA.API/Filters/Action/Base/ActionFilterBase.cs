using Microsoft.AspNetCore.Mvc.Filters;

namespace ITFCodeWA.API.Filters.Action.Base
{
    public abstract class ActionFilterBase : Attribute, IActionFilter
    {
        public virtual void OnActionExecuted(ActionExecutedContext context)
        {
            throw new NotImplementedException();
        }

        public virtual void OnActionExecuting(ActionExecutingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
