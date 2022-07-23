using ITFCodeWA.Core.Domain.Repositories.References;
using ITFCodeWA.Data.Finance.References;
using ITFCodeWA.Domain.DataContext;
using ITFCodeWA.Domain.Repositories.Finance.References.Intrefaces;
using System.Diagnostics.CodeAnalysis;

namespace ITFCodeWA.Domain.Repositories.Finance.References
{
    public class GoodRepository : ReferenceRepository<LifeDataContext, Good>, IGoodRepository
    {
        #region Constructors 

        public GoodRepository([NotNull] LifeDataContext context) : base(context) { }

        #endregion
    }
}