using ITFCodeWA.Core.Domain.Repositories.References;
using ITFCodeWA.Data.References;
using ITFCodeWA.Domain.DataContext;
using ITFCodeWA.Domain.Repositories.References.Interfaces;
using System.Diagnostics.CodeAnalysis;

namespace ITFCodeWA.Domain.Repositories.References
{
    public class FoodGroupRepository : ReferenceRepository<LifeDataContext, FoodGroup>, IFoodGroupRepository
    {
        #region Constructors 

        public FoodGroupRepository([NotNull] LifeDataContext context) : base(context) { }

        #endregion
    }
}