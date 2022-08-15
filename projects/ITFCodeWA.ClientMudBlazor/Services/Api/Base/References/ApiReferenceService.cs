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
    }
}