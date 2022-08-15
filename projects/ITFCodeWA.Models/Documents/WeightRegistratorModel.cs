using ITFCodeWA.Models.Health.Documents.Base;

namespace ITFCodeWA.Models.Documents
{
    public class WeightRegistratorModel : RegistratorBaseModel
    {
        public DateTimeOffset DateMonth { get; set; }

        public IList<WeightRegistratorRowModel> Rows { get; set; }
    }
}