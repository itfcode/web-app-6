using ITFCodeWA.ClientMudBlazor.Services.Api.Base.Interfaces;
using ITFCodeWA.Core.Models.Common.References.Interfaces;

namespace ITFCodeWA.ClientMudBlazor.Services.Api.Base.References.Interfaces
{
    public interface IApiReferenceService<TReferenceModel> : IApiEntityCrudService<TReferenceModel, int>
        where TReferenceModel : class, IReferenceModel
    {
    }
}