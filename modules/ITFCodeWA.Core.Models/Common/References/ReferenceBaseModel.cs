using ITFCodeWA.Core.Models.Common.Base;

namespace ITFCodeWA.Core.Models.Common.References
{
    public abstract class ReferenceBaseModel : EntityModel
    {
        public string Name { get; set; }
        public string Comment { get; set; }
    }
}