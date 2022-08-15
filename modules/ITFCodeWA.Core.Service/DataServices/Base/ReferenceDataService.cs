using AutoMapper;
using ITFCodeWA.Core.Data.Documents.Interfaces;
using ITFCodeWA.Core.Data.References.Interfaces;
using ITFCodeWA.Core.Domain.Repositories.References.Interfaces;
using ITFCodeWA.Core.Models;
using ITFCodeWA.Core.Models.Common.References.Interfaces;
using ITFCodeWA.Core.Models.QueryFilters;
using ITFCodeWA.Core.Services.DataServices.Base.Interfaces;
using ITFCodeWA.Core.Services.Operating.Interfaces;
using Microsoft.Extensions.Logging;

namespace ITFCodeWA.Core.Services.DataServices.Base
{
    public class ReferenceDataService<TRepository, TEntity, TEntityModel> : DataService<TRepository, TEntity, TEntityModel, int>,
            IReferenceDataService<TEntityModel>
        where TRepository : class, IReferenceRepository<TEntity>
        where TEntity : class, IReference
        where TEntityModel : class, IReferenceModel
    {
        #region Constructor

        public ReferenceDataService(ILogger<ReferenceDataService<TRepository, TEntity, TEntityModel>> logger,
            ICurrentUserService currentUserService,
            IMapper mapper,
            TRepository repository) : base(logger, currentUserService, mapper, repository) { }

        #endregion

        #region IReferenceDataService Implementation

        public virtual async Task<TEntityModel> GetByNameAsync(string name, CancellationToken cancellationToken = default)
            => Map(await _repository.FindByNameAsync(name, true, cancellationToken));

        public virtual async Task<IList<TEntityModel>> GetAllByNameAsync(string name, CancellationToken cancellationToken = default)
            => Map(await _repository.FindAllByNameAsync(name, true, cancellationToken));

        #endregion

        #region Overriding 

        protected override void ValidateQueryOptions(QueryOptions queryOptions)
        {
            base.ValidateQueryOptions(queryOptions);

            if (string.IsNullOrWhiteSpace(queryOptions.SortField))
            {
                queryOptions.SortField = nameof(IReference.Name);
                queryOptions.IsAsc = true;
            }
        }

        #endregion
    }
}