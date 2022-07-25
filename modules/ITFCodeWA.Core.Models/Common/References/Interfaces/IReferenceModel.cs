using ITFCodeWA.Core.Models.Common.Base.Interfaces;

namespace ITFCodeWA.Core.Models.Common.References.Interfaces
{
    public interface IReferenceModel : IEntityModel
    {
        string Name { get; }
        string Comment { get; }
    }
}
