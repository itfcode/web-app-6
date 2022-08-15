using ITFCodeWA.Data.References;
using ITFCodeWA.MapperConfig.Base.MappingProfiles;
using ITFCodeWA.MapperConfig.References.Resolvers;
using ITFCodeWA.Models.References;

namespace ITFCodeWA.MapperConfig.References
{
    public class PersonMappingProfile : ReferenceMappingProfile<Person, PersonModel>
    {
        protected override void ConfigureMap()
        {
            base.ConfigureMap();
            CreateMap<Person, PersonModel>()
                .ForMember(d => d.Name, r => r.MapFrom<PersonNameResolver>())
                .ReverseMap()
                    .ForMember(d => d.Name, r => r.MapFrom(s => s.LastName + " " + s.FirstName + " " + s.MiddleName + " (" + s.Utr.ToString() + ")"));
        }
    }
}