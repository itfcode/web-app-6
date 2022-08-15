using ITFCodeWA.Models.Health.Documents.Base;

namespace ITFCodeWA.Models.Documents
{
    public class WeightRegistratorRowModel : RegistratorRowBaseModel
    {
        public DateTimeOffset DateDay { get; set; }

        public decimal? Weight { get; set; }

    }
}
