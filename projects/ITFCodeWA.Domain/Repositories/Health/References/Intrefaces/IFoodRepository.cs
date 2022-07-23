using ITFCodeWA.Core.Domain.Repositories.References.Interfaces;
using ITFCodeWA.Data.Health.References;
using ITFCodeWA.Domain.DataContext;

namespace ITFCodeWA.Domain.Repositories.Health.References.Intrefaces
{
    public interface IFoodRepository : IReferenceRepository<LifeDataContext, Food>
    {
    }
}