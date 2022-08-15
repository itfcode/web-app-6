using ITFCodeWA.Core.Data.References;

namespace ITFCodeWA.Data.References
{
    public class GoodGroup : ReferenceBase
    {
        public ICollection<Good> Goods { get; set; }
    }
}