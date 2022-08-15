using AutoMapper;
using ITFCodeWA.Core.Services.DataServices.Base;
using ITFCodeWA.Core.Services.Operating.Interfaces;
using ITFCodeWA.Data.Documents;
using ITFCodeWA.Domain.Repositories.Documents.Interfaces;
using ITFCodeWA.Models.Documents;
using ITFCodeWA.Services.DataServices.Documents.Interfaces;
using Microsoft.Extensions.Logging;

namespace ITFCodeWA.Services.DataServices.Documents
{
    public class WeightRegistratorDataService : DocumentDataService<IWeightRegistratorRepository, WeightRegistrator, WeightRegistratorModel>, IWeightRegistratorDataService
    {
        #region Constructros 

        public WeightRegistratorDataService(ILogger<WeightRegistratorDataService> logger,
            ICurrentUserService currentUserService,
            IMapper mapper,
            IWeightRegistratorRepository repository) : base(logger, currentUserService, mapper, repository)
        {
        }

        #endregion
    }
}
