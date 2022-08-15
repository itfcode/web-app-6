using ITFCodeWA.Core.Domain.Repositories.References;
using ITFCodeWA.Data.References;
using ITFCodeWA.Domain.DataContext;
using ITFCodeWA.Domain.Repositories.References.Interfaces;
using System.Diagnostics.CodeAnalysis;

namespace ITFCodeWA.Domain.Repositories.References
{
    public class FoodRepository : ReferenceRepository<LifeDataContext, Food>, IFoodRepository
    {
        #region Constructors 

        public FoodRepository([NotNull] LifeDataContext context) : base(context) { }

        #endregion
    }
}