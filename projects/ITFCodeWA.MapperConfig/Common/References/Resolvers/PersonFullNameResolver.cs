using AutoMapper;
using ITFCodeWA.Data.Common.Reference;
using ITFCodeWA.Models.Common.References;

namespace ITFCodeWA.MapperConfig.Common.References.Resolvers
{
    public class PersonFullNameResolver : IValueResolver<Person, PersonModel, string>
    {
        public string Resolve(Person source, PersonModel destination, string destMember, ResolutionContext context) 
        {
            if (source is not null) 
                return (source.LastName + " " + source.FirstName + " " + source.MiddleName).Trim();

            return string.Empty;
        }
    }
}