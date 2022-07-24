using ITFCodeWA.Core.Domain.Repositories.Base.Interfaces;
using ITFCodeWA.Data.Common.Reference;
using ITFCodeWA.Domain.DataContext;

namespace ITFCodeWA.Domain.Repositories.Common.References.Interfaces
{
    public interface IPersonRepository : IRepository<LifeDataContext, Person, int>
    {
    }
}