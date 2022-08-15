using ITFCodeWA.Core.Domain.Exceptions.Base;

namespace ITFCodeWA.Core.Domain.Exceptions
{
    public class RepositoryAddException : RepositoryException
    {
        public RepositoryAddException(Exception innerException) : base(innerException) { }

        public RepositoryAddException(string? message, Exception? innerException) : base(message, innerException) { }
    }
}