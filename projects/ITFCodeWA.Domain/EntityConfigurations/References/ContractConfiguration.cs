using ITFCodeWA.Core.Domain.Extensions;
using Microsoft.EntityFrameworkCore;
using ITFCodeWA.Core.Domain.EntityConfigurations;
using ITFCodeWA.Data.References;

namespace ITFCodeWA.Domain.EntityConfigurations.References
{
    public class ContractConfiguration : ReferenceConfiguration<Contract>
    {
        public override void Configure()
        {
            base.Configure();

            _builder
                .ConfigProperty(p => p.StartDate, nameof(Contract.StartDate), true)
                .AddIndex(i => i.StartDate, isUnique: false)
                .ConfigProperty(p => p.FinishDate, nameof(Contract.FinishDate), true)
                .AddIndex(i => i.FinishDate, isUnique: false)
                .ConfigProperty(x => x.TotalCost, nameof(Contract.TotalCost), (18, 2), true)
                ;
        }
    }
}
