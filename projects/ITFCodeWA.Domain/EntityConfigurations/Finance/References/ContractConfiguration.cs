using ITFCodeWA.Data.Finance.References;
using ITFCodeWA.Core.Domain.Extensions;
using Microsoft.EntityFrameworkCore;
using ITFCodeWA.Core.Domain.EntityConfigurations.Base;

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

            _builder.Property(x => x.TotalCost)
                .HasColumnName(nameof(Contract.TotalCost))
                .HasPrecision(18, 2)
                .IsRequired();
        }
    }
}
