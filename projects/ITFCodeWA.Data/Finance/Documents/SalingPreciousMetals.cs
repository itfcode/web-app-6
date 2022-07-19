using ITFCodeWA.Core.Data.Documents;
using ITFCodeWA.Data.Finance.References;

namespace ITFCodeWA.Data.Finance.Documents
{
    /// <summary>
    /// Документ драгоценного металла валюты 
    /// </summary>
    public class SalingPreciousMetals : DocumentBase
    {
        public int PreciousMetalId { get; set; }

        public decimal Weight { get; set; }

        public PreciousMetal? PreciousMetal { get; set; }
    }
}
