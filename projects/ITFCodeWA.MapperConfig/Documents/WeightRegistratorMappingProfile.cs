using ITFCodeWA.Data.Documents;
using ITFCodeWA.MapperConfig.Base.MappingProfiles;
using ITFCodeWA.Models.Documents;

namespace ITFCodeWA.MapperConfig.Documents
{
    public class WeightRegistratorMappingProfile : DocumentMappingProfile<WeightRegistrator, WeightRegistratorModel>
    {
        protected override void ConfigureMap()
        {
            CreateMap<WeightRegistrator, WeightRegistratorModel>()
                .ForMember(d => d.PersonFullName,
                    r => r.MapFrom(s => s.Person != null ? (s.Person.LastName + " " + s.Person.FirstName + " " + s.Person.MiddleName) : "" ))
                .ReverseMap();
        }
    }
}