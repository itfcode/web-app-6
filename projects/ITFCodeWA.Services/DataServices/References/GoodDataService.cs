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
    public class GoodDataService : ReferenceDataService<IGoodRepository, Good, GoodModel>, IGoodDataService
    {
        #region Constructros 

        public GoodDataService(ILogger<GoodDataService> logger,
            ICurrentUserService currentUserService,
            IMapper mapper,
            IGoodRepository repository) : base(logger, currentUserService, mapper, repository)
        {
        }

        #endregion
    }
}