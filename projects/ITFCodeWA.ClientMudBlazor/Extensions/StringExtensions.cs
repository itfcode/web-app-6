using Newtonsoft.Json.Linq;

namespace ITFCodeWA.ClientMudBlazor.Extensions
{
    internal static class StringExtensions
    {
        #region Public Methods 

        public static bool ValidateJson(this string self)
             => Validate(() => JToken.Parse(self));

        public static bool ValidateJsonArray(this string self)
            => Validate(() => JArray.Parse(self));

        public static bool ValidateJsonObject(this string self)
            => Validate(() => JObject.Parse(self));

        #endregion

        #region Private Methods 

        private static bool Validate(Action parser)
        {
            try
            {
                parser();
                return true;
            }
            catch
            {
                return false;
            }
        }      

        #endregion
    }
}