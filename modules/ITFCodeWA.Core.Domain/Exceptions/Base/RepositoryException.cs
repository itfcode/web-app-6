namespace ITFCodeWA.Core.Domain.Exceptions.Base
{
    public abstract class RepositoryException : Exception
    {
        public RepositoryException(string? message) : base(message) { }

        public RepositoryException(string? message, Exception? innerException) : base(message, innerException) { }

        public RepositoryException(Exception innerException) : base(innerException.Message, innerException) { }
    }
}