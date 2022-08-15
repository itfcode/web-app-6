using AutoMapper;
using ITFCodeWA.Data.References;
using ITFCodeWA.Models.References;

namespace ITFCodeWA.MapperConfig.References.Resolvers
{
    public class PersonNameResolver : IValueResolver<Person, PersonModel, string>
    {
        public string Resolve(Person source, PersonModel destination, string destMember, ResolutionContext context)
        {
            if (source is not null)
                return (source.LastName + " " + source.FirstName + " " + source.MiddleName + "(" + source.Utr + ")").Trim();

            return string.Empty;
        }
    }
}