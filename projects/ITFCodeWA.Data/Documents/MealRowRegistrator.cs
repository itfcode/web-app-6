using ITFCodeWA.Data.Health.Documents.Base;
using ITFCodeWA.Data.References;

namespace ITFCodeWA.Data.Documents
{
    public class MealMakingRowRegistrator : RegistratorRowBase
    {
        public int FoodId { get; set; }

        public decimal Weight { get; set; }

        public Food? Food { get; set; }
    }
}