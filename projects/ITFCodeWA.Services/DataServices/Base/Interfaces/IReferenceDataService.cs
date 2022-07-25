using ITFCodeWA.Core.Models.Common.References.Interfaces;

namespace ITFCodeWA.Services.DataServices.Base.Interfaces
{
    public interface IReferenceDataService<TEntityModel> : IReadonlyDataService<TEntityModel, int>
        where TEntityModel : class, IReferenceModel
    {
    }
}