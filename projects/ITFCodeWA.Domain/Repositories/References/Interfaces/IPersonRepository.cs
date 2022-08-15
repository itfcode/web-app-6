using ITFCodeWA.Core.Domain.Repositories.Base.Interfaces;
using ITFCodeWA.Core.Domain.Repositories.References;
using ITFCodeWA.Core.Domain.Repositories.References.Interfaces;
using ITFCodeWA.Data.References;

namespace ITFCodeWA.Domain.Repositories.References.Interfaces
{
    public interface IPersonRepository : IReferenceRepository<Person>
    {
    }
}