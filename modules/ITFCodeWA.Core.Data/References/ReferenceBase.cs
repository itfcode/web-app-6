using ITFCodeWA.Core.Data.Base;
using ITFCodeWA.Core.Data.References.Interfaces;

namespace ITFCodeWA.Core.Data.References
{
    public abstract class ReferenceBase : Entity, IReference
    {
        public string Name { get; set; }

        public string Comment { get; set; }
    }
}
