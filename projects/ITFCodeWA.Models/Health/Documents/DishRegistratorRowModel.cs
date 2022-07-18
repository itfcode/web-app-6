using ITFCodeWA.Models.Health.Documents.Base;

namespace ITFCodeWA.Models.Health.Documents
{
    public class DishRegistratorRowModel : RegistratorRowBaseModel
    {
        public int FoodId { get; set; }

        public string? FoodName { get; set; }

        public decimal Weight { get; set; }

        public decimal CaloriesPer100 { get; set; }

        public decimal Calories { get; set; }
    }
}
