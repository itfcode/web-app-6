using ITFCodeWA.Models.Health.Enums;

namespace ITFCodeWA.Models.Health.References
{
    public class DietarySupplementModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LatinName { get; set; }

        public DietarySupplementType Type { get; set; }
    }
}
