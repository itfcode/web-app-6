using ITFCodeWA.Core.Domain.Exceptions.Base;

namespace ITFCodeWA.Core.Domain.Exceptions
{
    public class EntityRangeAddingException : DataContextException
    {
        public EntityRangeAddingException(Exception innerException) : base(innerException) { }

        public EntityRangeAddingException(string? message, Exception? innerException) : base(message, innerException) { }
    }
}