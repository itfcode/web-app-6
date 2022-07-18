using ITFCodeWA.Core.Data.References;

namespace ITFCodeWA.Data.Health.References
{
    public class Dish : ReferenceBase
    {
        public ICollection<Food> Components { get; set; }
    }
}