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
    public class RevenueGroupDataService : ReferenceDataService<IRevenueGroupRepository, RevenueGroup, RevenueGroupModel>, IRevenueGroupDataService
    {
        #region Constructros 

        public RevenueGroupDataService(ILogger<RevenueGroupDataService> logger,
            ICurrentUserService currentUserService,
            IMapper mapper,
            IRevenueGroupRepository repository) : base(logger, currentUserService, mapper, repository)
        {
        }

        #endregion
    }
}
