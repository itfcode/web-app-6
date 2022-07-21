using ITFCodeWA.Core.Domain.Exceptions.Base;

namespace ITFCodeWA.Core.Domain.Exceptions
{
    public class EntityRangeUpdatingException : DataContextException
    {
        public EntityRangeUpdatingException(Exception innerException) : base(innerException) { }

        public EntityRangeUpdatingException(string? message, Exception? innerException) : base(message, innerException) { }
    }
}