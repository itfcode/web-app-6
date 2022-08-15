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
    public class CurrencyDataService : ReferenceDataService<ICurrencyRepository, Currency, CurrencyModel>, ICurrencyDataService
    {
        #region Constructros 

        public CurrencyDataService(ILogger<CurrencyDataService> logger,
            ICurrentUserService currentUserService,
            IMapper mapper,
            ICurrencyRepository repository) : base(logger, currentUserService, mapper, repository)
        {
        }

        #endregion

        #region ICurrencyRepository Implementation

        public async Task<CurrencyModel> GetByCodeAsync(int code, CancellationToken cancellationToken = default)
            => Map(await _repository.FindAsync(x => x.Code == code, cancellationToken: cancellationToken));

        #endregion
    }
}
