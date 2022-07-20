using ITFCodeWA.Data.Health.Documents.Base;
using ITFCodeWA.Data.Health.References;

namespace ITFCodeWA.Data.Health.Documents
{
    public class MealMakingRegistrator : RegistratorBase
    {
        public int FoodId { get; set; }

        public Food? Food { get; set; }
    }
}
