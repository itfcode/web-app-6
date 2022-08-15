using ITFCodeWA.Data.References;

namespace ITFCodeWA.Data.Documents
{
    public class PharmaceuticalTakingPlan
    {
        public int PharmaceuticalId { get; set; }

        public DateTimeOffset StartDate { get; set; }

        public DateTimeOffset FinishDate { get; set; }

        public int QuantityPerDay { get; set; }

        public decimal Doze { get; set; }

        public Pharmaceutical Pharmaceutical { get; set; }
    }
}