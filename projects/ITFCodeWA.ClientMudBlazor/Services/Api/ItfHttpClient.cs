namespace ITFCodeWA.ClientMudBlazor.Services.Api
{
    public class ItfHttpClient : HttpClient
    {
        #region Constructors 

        public ItfHttpClient(HttpMessageHandler handler, IConfiguration configuration) : base(handler)
        {
            BaseAddress = new Uri(configuration["baseUrl"]);
            DefaultRequestHeaders.Clear();
        }

        #endregion
    }
}
