using ITFCodeWA.ClientMudBlazor.Services.Api.Base.Interfaces;
using ITFCodeWA.Core.Models.Common.Base.Interfaces;
using Newtonsoft.Json;
using System.Text;

namespace ITFCodeWA.ClientMudBlazor.Services.Api.Base
{
    public abstract class ApiEntityCrudService<TModel, TKey> : ApiEntityReadService<TModel, TKey>, IApiEntityCrudService<TModel, TKey>
        where TModel : class, IModel<TKey>
        where TKey : IComparable
    {
        #region Protected Properties 

        public virtual string RouteAdd => $"{_route}";
        public virtual string RouteUpdate => $"{_route}";
        public virtual string RouteDelete => $"{_route}/{{0}}";

        #endregion

        #region Constructors 

        public ApiEntityCrudService(ItfHttpClient httpClient, string route) : base(httpClient, route) { }

        #endregion

        #region IApiEntityCrudService Implementation

        public virtual async Task<TModel> AddAsync(TModel model, CancellationToken cancellationToken = default)
            => await PostAsync<TModel>(RouteAdd, model, cancellationToken);

        public virtual async Task<TModel> UpdateAsync(TModel model, CancellationToken cancellationToken = default)
            => await PutAsync<TModel>(RouteUpdate, model, cancellationToken);

        public virtual async Task<bool> DeleteAsync(TKey id, CancellationToken cancellationToken = default)
            => await DeleteAsync(string.Format(RouteDelete, id), cancellationToken);

        #endregion

        #region Private & Protected Methods 

        protected virtual async Task<TOut> PostAsync<TOut>(string uri, object item, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(uri, nameof(uri));
            ArgumentNullException.ThrowIfNull(item, nameof(item));

            var response = await _httpClient.PostAsync(GetUri(uri), ToStringContent(item), cancellationToken);

            return await ReadFromJsonAsync<TOut>(response);
        }

        protected virtual async Task<TOut> PutAsync<TOut>(string uri, object item, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(uri, nameof(uri));
            ArgumentNullException.ThrowIfNull(item, nameof(item));

            var response = await _httpClient.PutAsync(GetUri(uri), ToStringContent(item), cancellationToken);

            return await ReadFromJsonAsync<TOut>(response);
        }

        protected virtual async Task<bool> DeleteAsync(string uri, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(uri, nameof(uri));

            var response = await _httpClient.DeleteAsync(GetUri(uri), cancellationToken);

            return await ReadFromJsonAsync<bool>(response);
        }

        private StringContent ToStringContent(object item)
            => new(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");

        #endregion
    }
}