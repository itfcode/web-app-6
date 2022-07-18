using ITFCodeWA.Data.Health.References;

namespace ITFCodeWA.Data.Health.Documents
{
    public class PharmaceuticalRowRegistrator
    {
        public int PharmaceuticalId { get; set; }

        public decimal Quantity { get; set; }

        public Pharmaceutical? Pharmaceutical { get; set; }
    }
}
