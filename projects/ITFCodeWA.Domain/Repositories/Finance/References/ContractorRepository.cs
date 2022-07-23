using ITFCodeWA.Core.Domain.Repositories.References;
using ITFCodeWA.Data.Finance.References;
using ITFCodeWA.Domain.DataContext;
using ITFCodeWA.Domain.Repositories.Finance.References.Intrefaces;
using System.Diagnostics.CodeAnalysis;

namespace ITFCodeWA.Domain.Repositories.Finance.References
{
    public class ContractorRepository : ReferenceRepository<LifeDataContext, Contractor>, IContractorRepository
    {
        #region Constructors 

        public ContractorRepository([NotNull] LifeDataContext context) : base(context) { }

        #endregion
    }
}