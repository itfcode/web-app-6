using ITFCodeWA.Data.References;
using ITFCodeWA.MapperConfig.Base.MappingProfiles;
using ITFCodeWA.Models.References;

namespace ITFCodeWA.MapperConfig.References
{
    public class FoodMappingProfile : ReferenceMappingProfile<Food, FoodModel>
    {
        protected override void ConfigureMap()
        {
            CreateMap<Food, FoodModel>()
                .ReverseMap()
                    .ForMember(d => d.FoodGroup, r => r.Ignore());
        }
    }
}
