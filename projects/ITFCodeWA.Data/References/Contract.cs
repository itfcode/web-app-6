using ITFCodeWA.Core.Data.References;

namespace ITFCodeWA.Data.References
{
    public class Contract : ReferenceBase
    {
        public int CurrencyId { get; set; }

        public int ContractorId { get; set; }

        public DateTimeOffset StartDate { get; set; }

        public DateTimeOffset FinishDate { get; set; }

        public decimal TotalCost { get; set; }

        public Currency Currency { get; set; }

        public Contractor Contractor { get; set; }
    }
}