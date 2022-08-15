using ITFCodeWA.Data.Health.Documents.Base;
using ITFCodeWA.Data.References;

namespace ITFCodeWA.Data.Documents
{
    public class EatingRowRegistrator : RegistratorBase
    {
        public int FoodId { get; set; }

        public decimal Weight { get; set; }

        public Food? Food { get; set; }

        public EatingRegistrator? EatingRegistrator { get; set; }
    }
}
