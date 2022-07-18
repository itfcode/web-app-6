using ITFCodeWA.Core.Models.Common.References;
using ITFCodeWA.Models.Health.Enums;

namespace ITFCodeWA.Models.Health.References
{
    public class DietarySupplementModel : ReferenceBaseModel
    {
        public string Name { get; set; }

        public string LatinName { get; set; }

        public DietarySupplementType Type { get; set; }
    }
}
