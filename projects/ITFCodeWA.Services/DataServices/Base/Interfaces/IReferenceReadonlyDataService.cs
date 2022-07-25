using ITFCodeWA.Core.Models.Common.References.Interfaces;

namespace ITFCodeWA.Services.DataServices.Base.Interfaces
{
    public interface IReferenceReadonlyDataService<IEntityModel> : IReadonlyDataService<IEntityModel, int>
        where IEntityModel : class, IReferenceModel
    {
    }
}