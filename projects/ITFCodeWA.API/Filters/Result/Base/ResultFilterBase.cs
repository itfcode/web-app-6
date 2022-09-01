using Microsoft.AspNetCore.Mvc.Filters;

namespace ITFCodeWA.API.Filters.Result.Base
{
    public abstract class ResultFilterBase : IResultFilter
    {
        public virtual void OnResultExecuted(ResultExecutedContext context)
        {
            throw new NotImplementedException();
        }

        public virtual void OnResultExecuting(ResultExecutingContext context)
        {
            throw new NotImplementedException();
        }
    }
}