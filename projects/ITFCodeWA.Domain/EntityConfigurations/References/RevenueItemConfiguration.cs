using ITFCodeWA.Core.Domain.EntityConfigurations;
using ITFCodeWA.Core.Domain.Extensions;
using ITFCodeWA.Data.References;

namespace ITFCodeWA.Domain.EntityConfigurations.References
{
    public class RevenueItemConfiguration : ReferenceConfiguration<RevenueItem>
    {
        public override void Configure()
        {
            base.Configure();

            _builder
                .ConfigProperty(x => x.RevenueGroupId, nameof(RevenueItem.RevenueGroupId), true)
                .AddIndex(x => x.RevenueGroupId, isUnique: false)
                ;
        }
    }
}
