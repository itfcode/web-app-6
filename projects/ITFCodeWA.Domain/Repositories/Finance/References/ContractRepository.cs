using ITFCodeWA.Core.Domain.Repositories.References;
using ITFCodeWA.Data.Finance.References;
using ITFCodeWA.Domain.DataContext;
using ITFCodeWA.Domain.Repositories.Finance.References.Intrefaces;
using System.Diagnostics.CodeAnalysis;

namespace ITFCodeWA.Domain.Repositories.Finance.References
{
    public class ContractRepository : ReferenceRepository<LifeDataContext, Contract>, IContractRepository
    {
        #region Constructors 

        public ContractRepository([NotNull] LifeDataContext context) : base(context) { }

        #endregion
    }
}