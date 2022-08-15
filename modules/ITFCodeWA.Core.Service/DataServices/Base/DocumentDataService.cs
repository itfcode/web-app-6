using AutoMapper;
using ITFCodeWA.Core.Data.Documents.Interfaces;
using ITFCodeWA.Core.Domain.Repositories.Documents.Interfaces;
using ITFCodeWA.Core.Models;
using ITFCodeWA.Core.Models.Common.Documents.Interfaces;
using ITFCodeWA.Core.Models.QueryFilters;
using ITFCodeWA.Core.Services.DataServices.Base.Interfaces;
using ITFCodeWA.Core.Services.Operating.Interfaces;
using Microsoft.Extensions.Logging;

namespace ITFCodeWA.Core.Services.DataServices.Base
{
    public class DocumentDataService<TRepository, TEntity, TEntityModel> : DataService<TRepository, TEntity, TEntityModel, Guid>,
            IDocumentDataService<TEntityModel>
        where TRepository : class, IDocumentRepository<TEntity>
        where TEntity : class, IDocument
        where TEntityModel : class, IDocumentModel
    {
        #region Constructor

        public DocumentDataService(ILogger<DocumentDataService<TRepository, TEntity, TEntityModel>> logger,
            ICurrentUserService currentUserService,
            IMapper mapper,
            TRepository repository) : base(logger, currentUserService, mapper, repository) { }

        #endregion

        #region IDocumentDataService Implementation

        public virtual async Task<TEntityModel> GetByNumberAsync(int number, CancellationToken cancellationToken = default)
            => Map(await _repository.FindByNumberAsync(number, true, cancellationToken));

        #endregion

        #region Overriding 

        protected override void ValidateQueryOptions(QueryOptions queryOptions) 
        {
            base.ValidateQueryOptions(queryOptions);

            if (string.IsNullOrWhiteSpace(queryOptions.SortField))
            {
                queryOptions.SortField = nameof(IDocument.Date);
                queryOptions.IsAsc = false;
            }
        }

        #endregion
    }
}