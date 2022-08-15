using ITFCodeWA.Core.Data.References;

namespace ITFCodeWA.Data.References
{
    public class Meal : ReferenceBase
    {
        public ICollection<Food>? Components { get; set; }
    }
}