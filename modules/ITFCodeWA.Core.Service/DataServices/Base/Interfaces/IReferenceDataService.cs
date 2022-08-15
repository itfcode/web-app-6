using ITFCodeWA.Core.Models.Common.References.Interfaces;

namespace ITFCodeWA.Core.Services.DataServices.Base.Interfaces
{
    public interface IReferenceDataService<TEntityModel> : IDataService<TEntityModel, int>, 
            IReferenceReadOnlyDataService<TEntityModel>
        where TEntityModel : class, IReferenceModel
    {
    }
}