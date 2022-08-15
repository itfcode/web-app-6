using AutoMapper;
using ITFCodeWA.Core.Data.Base.Interface;
using ITFCodeWA.Core.Domain.Repositories.Base.Interfaces;
using ITFCodeWA.Core.Models.Common.Base.Interfaces;
using ITFCodeWA.Core.Services.DataServices.Base.Interfaces;
using ITFCodeWA.Core.Services.Operating.Interfaces;
using Microsoft.Extensions.Logging;

namespace ITFCodeWA.Core.Services.DataServices.Base
{
    public abstract class DataService<TRepository, TEntity, TEntityModel, TKey> : ReadOnlyDataService<TRepository, TEntity, TEntityModel, TKey>,
            IDataService<TEntityModel, TKey>
        where TRepository : class, IRepository<TEntity, TKey>
        where TEntity : class, IEntity<TKey>
        where TEntityModel : class, IModel<TKey>
        where TKey : IComparable
    {
        #region Constructors

        public DataService(ILogger<DataService<TRepository, TEntity, TEntityModel, TKey>> logger,
            ICurrentUserService currentUserService,
            IMapper mapper,
            TRepository repository) : base(logger, currentUserService, mapper, repository) { }

        #endregion

        #region IDataService Implemetation

        public virtual async Task<TEntityModel> CreateAsync(TEntityModel model, CancellationToken cancellationToken = default)
            => Map(await _repository.AddAsync(Map(model), true, cancellationToken));

        public virtual async Task CreateRangeAsync(IEnumerable<TEntityModel> models, CancellationToken cancellationToken = default)
            => await _repository.AddRangeAsync(Map(models), true, cancellationToken);

        public virtual async Task<TEntityModel> UpdateAsync(TEntityModel model, CancellationToken cancellationToken = default)
            => Map(await _repository.UpdateAsync(Map(model), true, cancellationToken));

        public virtual async Task UpdateRangeAsync(IEnumerable<TEntityModel> models, CancellationToken cancellationToken = default)
            => await _repository.UpdateRangeAsync(Map(models), true, cancellationToken);

        public virtual async Task DeleteAsync(TKey id, CancellationToken cancellationToken = default)
            => await _repository.DeleteAsync(id, true, cancellationToken);

        public virtual async Task DeleteRangeAsync(IEnumerable<TKey> ids, CancellationToken cancellationToken = default)
            => await _repository.DeleteRangeAsync(ids, true, cancellationToken);

        #endregion
    }
}