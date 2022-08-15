using ITFCodeWA.Core.Domain.EntityConfigurations;
using ITFCodeWA.Core.Domain.Extensions;
using ITFCodeWA.Data.References;

namespace ITFCodeWA.Domain.EntityConfigurations.References
{
    public class ExpenseItemConfiguration : ReferenceConfiguration<ExpenseItem>
    {
        public override void Configure()
        {
            base.Configure();

            _builder
                .ConfigProperty(x => x.ExpenseGroupId, nameof(ExpenseItem.ExpenseGroupId), true)
                .AddIndex(x => x.ExpenseGroupId, isUnique: false)
                ;
        }
    }
}