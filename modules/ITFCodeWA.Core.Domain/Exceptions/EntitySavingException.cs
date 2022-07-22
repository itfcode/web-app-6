using ITFCodeWA.Core.Domain.Exceptions.Base;

namespace ITFCodeWA.Core.Domain.Exceptions
{
    public class EntityCommitingException : DataContextException
    {
        public EntityCommitingException(Exception innerException) : base(innerException) { }

        public EntityCommitingException(string? message, Exception? innerException) : base(message, innerException) { }
    }
}