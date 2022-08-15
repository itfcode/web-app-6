using ITFCodeWA.ClientMudBlazor.Services.Api.Base.Interfaces;
using ITFCodeWA.Core.Models;
using ITFCodeWA.Core.Models.Common.Base.Interfaces;
using ITFCodeWA.Core.Models.QueryFilters;

namespace ITFCodeWA.ClientMudBlazor.Services.Api.Base
{
    public abstract class ApiEntityReadService<TModel, TKey> : ApiBaseService, IApiEntityReadService<TModel, TKey>
        where TModel : class, IModel<TKey>
        where TKey : IComparable
    {

        #region MyRegion

        public virtual string RouteGet => $"{_route}/{{0}}";

        public virtual string RouteGetPage => $"{_route}/page";

        #endregion

        #region Constructors 

        public ApiEntityReadService(ItfHttpClient httpClient, string route) : base(httpClient, route) { }

        #endregion

        #region IApiEntityReadService Implementation

        public virtual async Task<TModel> GetByIdAsync(TKey id, CancellationToken cancellationToken = default)
           => await GetAsync<TModel>($"{string.Format(RouteGet, id)}");

        public virtual async Task<PageResult<TModel>> GetPageAsync(QueryOptions queryOptions = default!, CancellationToken cancellationToken = default)
            => await GetPageAsync<TModel>(RouteGetPage, queryOptions);

        #endregion
    }
}