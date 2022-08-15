using ITFCodeWA.Data.References;

namespace ITFCodeWA.Data.Documents
{
    public class PharmaceuticalRowRegistrator
    {
        public int PharmaceuticalId { get; set; }

        public decimal Quantity { get; set; }

        public Pharmaceutical? Pharmaceutical { get; set; }
    }
}
