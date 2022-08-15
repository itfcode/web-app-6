using ITFCodeWA.Core.Domain.EntityConfigurations;
using ITFCodeWA.Core.Domain.Extensions;
using ITFCodeWA.Data.Documents;

namespace ITFCodeWA.Domain.EntityConfigurations.Documents
{
    public class WeightRegistratorRowConfiguration : DocumentRowConfiguration<WeightRegistratorRow>
    {
        public override void Configure()
        {
            base.Configure();

            _builder
                .ConfigProperty(x => x.Weight, nameof(WeightRegistratorRow.Weight), (10, 1), true)
                .ConfigProperty(x => x.DateDay, nameof(WeightRegistratorRow.DateDay), true, columnOrder: 2)
                .ConfigProperty(x => x.RowNumber, nameof(WeightRegistratorRow.DateDay), true, columnOrder: 1)
            ;
        }
    }
}