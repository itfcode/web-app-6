using ITFCodeWA.Core.Data.Documents;
using ITFCodeWA.Data.References;

namespace ITFCodeWA.Data.Documents
{
    /// <summary>
    /// Документ покупики драгоценного металла валюты 
    /// </summary>
    public class BuyingPreciousMetals : DocumentBase
    {
        public int BuyerId { get; set; }

        public int PreciousMetalId { get; set; }

        public int ContraсtortId { get; set; }

        public int ContractId { get; set; }

        public decimal Weight { get; set; }

        public Person? Buyer { get; set; }

        public Contractor? Contraсtor { get; set; }

        public Contract? Contract { get; set; }

        public PreciousMetal? PreciousMetal { get; set; }
    }
}
