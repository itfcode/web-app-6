using Microsoft.AspNetCore.Mvc.Filters;

namespace ITFCodeWA.API.Filters.Exception.Base
{ 
    public abstract class ExceptionFilterBase : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            throw new NotImplementedException();
        }
    }
}