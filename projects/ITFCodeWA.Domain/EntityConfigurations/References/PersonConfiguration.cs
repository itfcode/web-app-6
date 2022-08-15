using ITFCodeWA.Domain.EntityConfigurations.Base;
using ITFCodeWA.Core.Domain.Extensions;
using ITFCodeWA.Data.References;

namespace ITFCodeWA.Domain.EntityConfigurations.References
{
    public class PersonConfiguration : EntityConfigurationBase<Person, int>
    {
        public override void Configure()
        {
            base.Configure();

            _builder
                .ConfigProperty(p => p.Name, nameof(Person.Name), true, 99)
                .ConfigProperty(p => p.Comment, nameof(Person.Comment), true, 29)
                .ConfigProperty(p => p.FirstName, nameof(Person.FirstName), true, 29)
                .ConfigProperty(p => p.MiddleName, nameof(Person.MiddleName), true, 29)
                .ConfigProperty(p => p.LastName, nameof(Person.LastName), true, 29)
                .AddIndex(i => i.FirstName, isUnique: false)
                .AddIndex(i => i.MiddleName, isUnique: false)
                .AddIndex(i => i.LastName, isUnique: false)
                ;
        }
    }
}
