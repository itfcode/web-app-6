using ITFCodeWA.ClientMudBlazor.Exceptions;
using ITFCodeWA.ClientMudBlazor.Services.Api.Base.Interfaces;
using ITFCodeWA.Core.Models;
using ITFCodeWA.Core.Models.QueryFilters;
using Newtonsoft.Json;

namespace ITFCodeWA.ClientMudBlazor.Services.Api.Base
{
    public abstract class ApiBaseService : IApiService
    {
        #region Private & Protected Fields 

        protected readonly ItfHttpClient _httpClient;

        protected readonly string _route;

        #endregion

        #region Protected Properties 

        public Uri Host => _httpClient?.BaseAddress;

        #endregion

        #region Constructors 

        public ApiBaseService(ItfHttpClient httpClient, string route)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            _route = route;
        }

        #endregion

        #region Protected Methods 

        protected virtual async Task<PageResult<T>> GetPageAsync<T>(string uri, QueryOptions queryOptions = default!) where T : class
        {
            var response = await _httpClient.GetAsync(QueryStringFactory.Generate(uri, queryOptions));

            return await ReadFromJsonAsync<PageResult<T>>(response);
        }

        protected string GetUri(string endpoint)
            => new Uri(_httpClient.BaseAddress, endpoint).AbsoluteUri;

        protected virtual async Task<T> GetAsync<T>(string uri) where T : class
        {
            Console.WriteLine($"URI is '{uri}'");
            return await ReadFromJsonAsync<T>(await _httpClient.GetAsync(uri));
        }

        protected async Task<T> ReadFromJsonAsync<T>(HttpResponseMessage response)
        {
            try
            {
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                return content is not null ? JsonConvert.DeserializeObject<T>(content) : default;
            }
            catch (HttpRequestException ex)
            {
                var content = await response.Content.ReadAsStringAsync();
                throw new ItfApplicationException(ex.Message, content);
            }
            catch (Exception ex)
            {
                throw new ItfApplicationException(ex.Message, ex.InnerException != null ? ex.Message : ex.StackTrace);
            }
        }

        #endregion
    }
}