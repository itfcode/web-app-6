using AutoMapper;
using ITFCodeWA.Core.Services.DataServices.Base;
using ITFCodeWA.Core.Services.Operating.Interfaces;
using ITFCodeWA.Data.References;
using ITFCodeWA.Domain.Repositories.References.Interfaces;
using ITFCodeWA.Models.References;
using ITFCodeWA.Services.DataServices.References.Interfaces;
using Microsoft.Extensions.Logging;

namespace ITFCodeWA.Services.DataServices.References
{
    public class ContractorDataService : ReferenceDataService<IContractorRepository, Contractor, ContractorModel>, IContractorDataService
    {
        #region Constructros 

        public ContractorDataService(ILogger<ContractorDataService> logger,
            ICurrentUserService currentUserService,
            IMapper mapper,
            IContractorRepository repository) : base(logger, currentUserService, mapper, repository)
        {
        }

        #endregion
    }
}
