using ITFCodeWA.Core.Domain.Exceptions.Base;

namespace ITFCodeWA.Core.Domain.Exceptions
{
    public class DbSetAddRangeException : RepositoryException
    {
        public DbSetAddRangeException(Exception innerException) : base(innerException) { }

        public DbSetAddRangeException(string? message, Exception? innerException) : base(message, innerException) { }
    }
}