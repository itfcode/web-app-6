using ITFCodeWA.Core.Domain.Repositories.References;
using ITFCodeWA.Data.References;
using ITFCodeWA.Domain.DataContext;
using ITFCodeWA.Domain.Repositories.References.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace ITFCodeWA.Domain.Repositories.References
{
    public class FoodRepository : ReferenceRepository<LifeDataContext, Food>, IFoodRepository
    {
        #region Constructors 

        public FoodRepository([NotNull] LifeDataContext context) : base(context) { }

        #endregion

        #region Private && Protected Methods 

        protected override IQueryable<Food> GetOneWithDetails()
            => DbSet.Include(x => x.FoodGroup);

        protected override IQueryable<Food> GetManyWithDetails()
            => DbSet.Include(x => x.FoodGroup);

        #endregion
    }
}