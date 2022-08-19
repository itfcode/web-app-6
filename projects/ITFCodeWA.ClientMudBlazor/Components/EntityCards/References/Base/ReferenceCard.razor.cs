using ITFCodeWA.ClientMudBlazor.Components.EntityCards.Base;
using ITFCodeWA.ClientMudBlazor.Services.Api.Base.References.Interfaces;
using ITFCodeWA.Core.Models.Common.References.Interfaces;

namespace ITFCodeWA.ClientMudBlazor.Components.EntityCards.References.Base
{
    public partial class ReferenceCard<TModel, TApiService> : EntityCardBase<TModel, int, TApiService>
        where TModel : class, IReferenceModel, new()
        where TApiService : class, IApiReferenceService<TModel>
    {

    }
}