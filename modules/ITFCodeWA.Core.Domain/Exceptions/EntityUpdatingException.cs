using ITFCodeWA.Core.Domain.Exceptions.Base;

namespace ITFCodeWA.Core.Domain.Exceptions
{
    public class EntityUpdatingException : DataContextException
    {
        public EntityUpdatingException(Exception innerException) : base(innerException) { }

        public EntityUpdatingException(string? message, Exception? innerException) : base(message, innerException) { }
    }
}