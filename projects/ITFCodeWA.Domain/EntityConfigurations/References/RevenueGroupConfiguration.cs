using ITFCodeWA.Core.Domain.EntityConfigurations;
using ITFCodeWA.Data.References;
using Microsoft.EntityFrameworkCore;

namespace ITFCodeWA.Domain.EntityConfigurations.References
{
    public class RevenueGroupConfiguration : ReferenceConfiguration<RevenueGroup>
    {
        public override void Configure()
        {
            base.Configure();

            _builder.HasMany(c => c.RevenueItems)
               .WithOne(e => e.RevenueGroup)
               .HasForeignKey(x => x.RevenueGroupId)
               .OnDelete(DeleteBehavior.Cascade)
               ;
        }
    }
}