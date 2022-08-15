using ITFCodeWA.Core.Domain.Repositories.References;
using ITFCodeWA.Data.References;
using ITFCodeWA.Domain.DataContext;
using ITFCodeWA.Domain.Repositories.References.Interfaces;
using System.Diagnostics.CodeAnalysis;

namespace ITFCodeWA.Domain.Repositories.References
{
    public class ContractorRepository : ReferenceRepository<LifeDataContext, Contractor>, IContractorRepository
    {
        #region Constructors 

        public ContractorRepository([NotNull] LifeDataContext context) : base(context) { }

        #endregion
    }
}