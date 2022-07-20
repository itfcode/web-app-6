using ITFCodeWA.Data.Health.Documents.Base;
using ITFCodeWA.Data.Health.References;

namespace ITFCodeWA.Data.Health.Documents
{
    public class MealRegistrator : RegistratorBase
    {
        public int FoodId { get; set; }

        public Food? Food { get; set; }
    }
}
