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
    public class PersonDataService : ReferenceDataService<IPersonRepository, Person, PersonModel>, IPersonDataService
    {
        #region Constructros 

        public PersonDataService(ILogger<PersonDataService> logger,
            ICurrentUserService currentUserService,
            IMapper mapper,
            IPersonRepository repository) : base(logger, currentUserService, mapper, repository)
        {
        }

        #endregion

        #region IPersonDataService Implementation

        public async Task<PersonModel> GetByUtrAsync(long utr, CancellationToken cancellationToken = default)
            => Map(await _repository.FindAsync(x => x.Utr == utr, false, cancellationToken));

        #endregion
    }
}
