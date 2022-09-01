using Microsoft.AspNetCore.Mvc.Filters;

namespace ITFCodeWA.API.Filters.Resource.Base
{
    public abstract class ResourceFilterBase : IResourceFilter
    {
        public virtual void OnResourceExecuted(ResourceExecutedContext context)
        {
            throw new NotImplementedException();
        }

        public virtual void OnResourceExecuting(ResourceExecutingContext context)
        {
            throw new NotImplementedException();
        }
    }
}