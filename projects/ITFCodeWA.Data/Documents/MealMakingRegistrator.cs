using ITFCodeWA.Data.Health.Documents.Base;
using ITFCodeWA.Data.References;

namespace ITFCodeWA.Data.Documents
{
    public class MealMakingRegistrator : RegistratorBase
    {
        public int FoodId { get; set; }

        public Food? Food { get; set; }
    }
}
