using ITFCodeWA.Data.Finance.References;
using ITFCodeWA.Domain.EntityConfigurations.Base;
using ITFCodeWA.Core.Domain.Extensions;

namespace ITFCodeWA.Domain.EntityConfigurations.Finance.References
{
    public class ContractConfiguration : ReferenceConfiguration<Contract>
    {
        public override void Configure()
        {
            base.Configure();

            _builder
                .ConfigProperty(p => p.StartDate, nameof(Contract.StartDate), true)
                .ConfigProperty(p => p.FinishDate, nameof(Contract.FinishDate), true)
                .AddIndex(i => i.StartDate, isUnique: false)
                .AddIndex(i => i.FinishDate, isUnique: false);
        }
    }
}
