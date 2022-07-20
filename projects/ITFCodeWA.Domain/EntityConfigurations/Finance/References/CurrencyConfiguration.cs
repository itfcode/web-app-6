using ITFCodeWA.Data.Finance.References;
using ITFCodeWA.Domain.EntityConfigurations.Base;
using Microsoft.EntityFrameworkCore;
using ITFCodeWA.Core.Domain.Extensions;

namespace ITFCodeWA.Domain.EntityConfigurations.Finance.References
{
    public class CurrencyConfiguration : ReferenceConfiguration<Currency>
    {
        public override void Configure()
        {
            base.Configure();

            _builder
                .ConfigProperty(p => p.ShortName, nameof(Currency.ShortName), true, 3)
                .ConfigProperty(p => p.Code, nameof(Currency.Code), true)
                .AddIndex(i => i.ShortName, isUnique: true)
                .AddIndex(i => i.Code, isUnique: true)
                .HasCheckConstraint("CK_Currency_Code", "Code > 0 AND Code < 999");
        }
    }
}
