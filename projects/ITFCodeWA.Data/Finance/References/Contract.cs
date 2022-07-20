using ITFCodeWA.Core.Data.References;

namespace ITFCodeWA.Data.Finance.References
{
    public class Contract : ReferenceBase
    {
        public int ContractorId { get; set; }

        public DateTimeOffset StartDate { get; set; }

        public DateTimeOffset FinishDate { get; set; }

        public Contractor Contractor { get; set; }
    }
}
