using ITFCodeWA.Core.Data.Base.Interface;

namespace ITFCodeWA.Core.Data.References.Interfaces
{
    public interface IReference : IEntity
    {
        string Name { get; set; }
        string Comment { get; set; }
    }
}
