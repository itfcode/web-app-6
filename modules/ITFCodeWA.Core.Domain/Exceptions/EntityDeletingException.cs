using ITFCodeWA.Core.Domain.Exceptions.Base;

namespace ITFCodeWA.Core.Domain.Exceptions
{
    public class EntityDeletingException : DataContextException
    {
        public EntityDeletingException(Exception innerException) : base(innerException) { }

        public EntityDeletingException(string message, Exception? innerException) : base(message, innerException) { }
    }
}