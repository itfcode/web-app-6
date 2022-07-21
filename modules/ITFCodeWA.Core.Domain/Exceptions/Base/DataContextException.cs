namespace ITFCodeWA.Core.Domain.Exceptions.Base
{
    public abstract class DataContextException : Exception
    {
        public DataContextException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
