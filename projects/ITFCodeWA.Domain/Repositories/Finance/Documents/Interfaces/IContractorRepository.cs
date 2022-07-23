using ITFCodeWA.Core.Domain.Repositories.Base.Interfaces;
using ITFCodeWA.Data.Finance.References;
using ITFCodeWA.Domain.DataContext;

namespace ITFCodeWA.Domain.Repositories.Finance.References.Interfaces
{
    public interface IContractorRepository : IRepository<LifeDataContext, Contractor, int>
    {
    }
}