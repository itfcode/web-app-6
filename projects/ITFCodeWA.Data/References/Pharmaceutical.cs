using ITFCodeWA.Core.Data.References;
using ITFCodeWA.Data.Enums;

namespace ITFCodeWA.Data.References
{
    /// <summary>
    /// Фармацевтический препарат
    /// </summary>
    public class Pharmaceutical : ReferenceBase
    {
        public PharmaceuticalType Kind { get; set; }
    }
}
