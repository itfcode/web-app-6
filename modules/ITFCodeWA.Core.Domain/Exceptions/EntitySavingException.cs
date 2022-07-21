using ITFCodeWA.Core.Domain.Exceptions.Base;

namespace ITFCodeWA.Core.Domain.Exceptions
{
    public class EntitySavingException : DataContextException
    {
        public EntitySavingException(Exception innerException) : base(innerException) { }

        public EntitySavingException(string? message, Exception? innerException) : base(message, innerException) { }
    }
}