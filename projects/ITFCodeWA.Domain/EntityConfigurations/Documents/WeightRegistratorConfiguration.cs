using ITFCodeWA.Core.Domain.EntityConfigurations;
using ITFCodeWA.Core.Domain.Extensions;
using ITFCodeWA.Data.Documents;
using Microsoft.EntityFrameworkCore;

namespace ITFCodeWA.Domain.EntityConfigurations.Documents
{
    public class WeightRegistratorConfiguration : DocumentConfiguration<WeightRegistrator>
    {
        public override void Configure()
        {
            base.Configure();

            _builder
                .ConfigProperty(x => x.PersonId, nameof(WeightRegistrator.PersonId), true)
                .ConfigProperty(x => x.DateMonth, nameof(WeightRegistrator.DateMonth), true)
                .AddIndex(x => x.PersonId, isUnique: false)
                ;

            _builder.HasMany(c => c.Rows)
               .WithOne(e => e.WeightRegistrator)
               .HasForeignKey(x => x.DocumentId)
               .OnDelete(DeleteBehavior.Cascade)
               ;
        }
    }
}