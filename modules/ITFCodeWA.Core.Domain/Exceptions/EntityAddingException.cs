using ITFCodeWA.Core.Domain.Exceptions.Base;

namespace ITFCodeWA.Core.Domain.Exceptions
{
    public class EntityAddingException : DataContextException
    {
        public EntityAddingException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}