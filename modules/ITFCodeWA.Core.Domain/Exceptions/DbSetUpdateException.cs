using ITFCodeWA.Core.Domain.Exceptions.Base;

namespace ITFCodeWA.Core.Domain.Exceptions
{
    public class DbSetUpdateException : RepositoryException
    {
        public DbSetUpdateException(Exception innerException) : base(innerException) { }

        public DbSetUpdateException(string? message, Exception? innerException) : base(message, innerException) { }
    }
}