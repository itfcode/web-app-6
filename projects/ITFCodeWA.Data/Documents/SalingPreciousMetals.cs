using ITFCodeWA.Core.Data.Documents;
using ITFCodeWA.Data.References;

namespace ITFCodeWA.Data.Documents
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
