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
    public class GoodGroupDataService : ReferenceDataService<IGoodGroupRepository, GoodGroup, GoodGroupModel>, IGoodGroupDataService
    {
        #region Constructros 

        public GoodGroupDataService(ILogger<GoodGroupDataService> logger,
            ICurrentUserService currentUserService,
            IMapper mapper,
            IGoodGroupRepository repository) : base(logger, currentUserService, mapper, repository)
        {
        }

        #endregion
    }
}
