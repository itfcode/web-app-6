using ITFCodeWA.Core.Domain.Repositories.References;
using ITFCodeWA.Data.Health.References;
using ITFCodeWA.Domain.DataContext;
using ITFCodeWA.Domain.Repositories.Health.References.Intrefaces;
using System.Diagnostics.CodeAnalysis;

namespace ITFCodeWA.Domain.Repositories.Health.References
{
    public class FoodRepository : ReferenceRepository<LifeDataContext, Food>,  IFoodRepository
    {
        #region Constructors 

        public FoodRepository([NotNull] LifeDataContext context) : base(context) { }

        #endregion
    }
}