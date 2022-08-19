using ITFCodeWA.ClientMudBlazor.Services.Api.Base.References.Interfaces;
using ITFCodeWA.Core.Models.Common.References.Interfaces;

namespace ITFCodeWA.ClientMudBlazor.Services.Api.Base.References
{
    public abstract class ApiReferenceService<TReferenceModel> : ApiEntityCrudService<TReferenceModel, int>, IApiReferenceService<TReferenceModel>
        where TReferenceModel : class, IReferenceModel
    {
        #region Constructor

        public ApiReferenceService(ItfHttpClient httpClient, string route) : base(httpClient, route) { }

        #endregion

        #region IApiReferenceService Implementation

        public virtual async Task<IEnumerable<TReferenceModel>> FindByValueAsync(string value)
        {
            throw new NotImplementedException();
            //var url = $"{RouteGetAll}/find/{(value ?? string.Empty).ToLower()}";
            //return await GetAllAsync<IEnumerable<TModel>>(url);
        }

        #endregion
    }
}