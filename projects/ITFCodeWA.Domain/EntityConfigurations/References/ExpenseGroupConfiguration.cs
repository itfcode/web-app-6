using ITFCodeWA.Core.Domain.EntityConfigurations;
using ITFCodeWA.Core.Domain.Extensions;
using ITFCodeWA.Data.References;
using Microsoft.EntityFrameworkCore;

namespace ITFCodeWA.Domain.EntityConfigurations.References
{
    public class ExpenseGroupConfiguration : ReferenceConfiguration<ExpenseGroup>
    {
        public override void Configure()
        {
            base.Configure();

            _builder.HasMany(c => c.ExpenseItems)
               .WithOne(e => e.ExpenseGroup)
               .HasForeignKey(x => x.ExpenseGroupId)
               .OnDelete(DeleteBehavior.Cascade)
               ;
        }
    }
}
