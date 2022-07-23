using ITFCodeWA.Core.Domain.Exceptions.Base;

namespace ITFCodeWA.Core.Domain.Exceptions
{
    public class EntityRangeDeletingException : RepositoryException
    {
        public EntityRangeDeletingException(Exception innerException) : base(innerException) { }

        public EntityRangeDeletingException(string message, Exception? innerException) : base(message, innerException) { }
    }
}