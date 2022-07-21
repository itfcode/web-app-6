using ITFCodeWA.Core.Domain.Exceptions.Base;

namespace ITFCodeWA.Core.Domain.Exceptions
{
    public class EntityUpdatingException : DataContextException
    {
        public EntityUpdatingException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}