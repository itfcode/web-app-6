using ITFCodeWA.Core.Data.References;

namespace ITFCodeWA.Data.Health.References
{
    public class Food : ReferenceBase
    {
        public decimal Proteins { get; set; }
        
        public decimal Fats { get; set; }

        public decimal Carbohydrates { get; set; }

        public decimal Calories { get; set; }

        public ICollection<Dish> Dish { get; set; }
    }
}