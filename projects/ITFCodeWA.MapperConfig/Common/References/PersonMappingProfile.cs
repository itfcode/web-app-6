using ITFCodeWA.Core.Models.Common.References;
using ITFCodeWA.Data.Common.Reference;
using ITFCodeWA.MapperConfig.Base.MappingProfiles;
using ITFCodeWA.MapperConfig.Common.References.Resolvers;
using ITFCodeWA.Models.Common.References;

namespace ITFCodeWA.MapperConfig.Common.References
{
    public class PersonMappingProfile : ReferenceMappingProfile<Person, PersonModel>
    {
        protected override void ConfigureMap()
        {
            base.ConfigureMap();
            CreateMap<Person, PersonModel>()
                .ForMember(d => d.FullName, r => r.MapFrom<PersonFullNameResolver>())
                .ReverseMap()
                    .ForMember(d => d.Name, m => m.Ignore());
        }
    }
}