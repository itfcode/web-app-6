using ITFCodeWA.Core.Domain.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using ITFCodeWA.Core.Domain.Extensions;
using ITFCodeWA.Data.References;

namespace ITFCodeWA.Domain.EntityConfigurations.References
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
