using ITFCodeWA.ClientMudBlazor.Extensions;

namespace ITFCodeWA.ClientMudBlazor.Exceptions
{
    public class ItfApplicationException : Exception
    {
        #region Public Properties 

        public Dictionary<string, string> ErrorDetails { get; }

        #endregion

        #region Constructors 

        public ItfApplicationException(string message, string content) : base(message)
        {
            if (content != null)
            {
                if (content.ValidateJson())
                {
                    // ErrorDetails = JsonStringValueConverter.GetJsonValues(content);
                }
                else
                {
                    // ErrorDetails = new Dictionary<string, string> { { "Error", content } };
                }
            }
        }

        #endregion
    }
}