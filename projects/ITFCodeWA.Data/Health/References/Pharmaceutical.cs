using ITFCodeWA.Core.Data.References;
using ITFCodeWA.Data.Health.Enums;

namespace ITFCodeWA.Data.Health.References
{
    /// <summary>
    /// Фармацевтический препарат
    /// </summary>
    public class Pharmaceutical : ReferenceBase
    {
        public PharmaceuticalType Kind { get; set; }
    }
}
