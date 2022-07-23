using ITFCodeWA.Core.Domain.Repositories.References.Interfaces;
using ITFCodeWA.Data.Finance.References;
using ITFCodeWA.Domain.DataContext;

namespace ITFCodeWA.Domain.Repositories.Finance.References.Intrefaces
{
    public interface IRevenueItemRepository : IReferenceRepository<LifeDataContext, RevenueItem>
    {
    }
}