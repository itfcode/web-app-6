using ITFCodeWA.ClientMudBlazor.Components.EntityForms.Base;
using ITFCodeWA.ClientMudBlazor.Services.Api.Base.References.Interfaces;
using ITFCodeWA.Core.Models.Common.References.Interfaces;
using Microsoft.AspNetCore.Components;

namespace ITFCodeWA.ClientMudBlazor.Components.EntityForms.References.Base
{
    public class ReferenceFormView<TModel, TApiService> : EntityFormView<TModel, int, TApiService>
        where TModel : class, IReferenceModel, new()
        where TApiService : class, IApiReferenceService<TModel>
    {
    }
}
