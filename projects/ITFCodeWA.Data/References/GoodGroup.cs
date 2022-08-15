using ITFCodeWA.Core.Data.References;

namespace ITFCodeWA.Data.References
{
    public class FoodGroup : ReferenceBase
    {
        public ICollection<Food> Foods { get; set; }
    }
}