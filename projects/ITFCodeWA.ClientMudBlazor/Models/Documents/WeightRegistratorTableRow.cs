using ITFCodeWA.Models.Documents;

namespace ITFCodeWA.ClientMudBlazor.Models.Documents
{
    public class WeightRegistratorTableRow
    {
        public WeightRegistratorRowModel[] Days { get; set; } = new WeightRegistratorRowModel[7];
    }
}
