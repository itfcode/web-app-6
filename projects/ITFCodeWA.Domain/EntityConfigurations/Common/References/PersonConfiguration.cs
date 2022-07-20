using ITFCodeWA.Domain.EntityConfigurations.Base;
using ITFCodeWA.Data.Common.Reference;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ITFCodeWA.Domain.EntityConfigurations.Common.References
{
    public class PersonConfiguration : EntityConfigurationBase<Person, int>
    {
        public override void Configure(EntityTypeBuilder<Person> builder)
        {
            base.Configure(builder);
        }
    }
}
