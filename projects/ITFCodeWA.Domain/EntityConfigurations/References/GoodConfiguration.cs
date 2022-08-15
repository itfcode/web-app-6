using ITFCodeWA.Core.Domain.EntityConfigurations;
using ITFCodeWA.Core.Domain.Extensions;
using ITFCodeWA.Data.References;

namespace ITFCodeWA.Domain.EntityConfigurations.References
{
    public class GoodConfiguration : ReferenceConfiguration<Good>
    {
        public override void Configure()
        {       
            base.Configure();

            _builder
                .ConfigProperty(x => x.ExpenseItemId, nameof(Good.ExpenseItemId), true)
                .ConfigProperty(x => x.RevenueItemId, nameof(Good.RevenueItemId), true)
                .ConfigProperty(x => x.GoodGroupId, nameof(Good.GoodGroupId), true)
                .AddIndex(x => x.GoodGroupId, isUnique: false)
                ;
        }
    }
}
