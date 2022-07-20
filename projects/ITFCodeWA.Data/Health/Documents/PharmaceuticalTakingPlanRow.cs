using ITFCodeWA.Data.Health.References;

namespace ITFCodeWA.Data.Health.Documents
{
    public class PharmaceuticalTakingPlanRow
    {
        public int PharmaceuticalId { get; set; } 

        public DateTimeOffset StartDate { get; set; }

        public DateTimeOffset FinishDate { get; set; }

        public int QuantityPerDay { get; set; }

        public decimal Doze { get; set; }

        public Pharmaceutical Pharmaceutical { get; set; }
    }
}