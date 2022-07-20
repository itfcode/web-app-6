using ITFCodeWA.Core.Data.Base.Interface;
using ITFCodeWA.Core.Domain.EntityConfiguration;

namespace ITFCodeWA.Domain.EntityConfigurations.Base
{
    public abstract class EntityConfigurationBase<TEntity, TKey> : EntityConfigurationCore<TEntity, TKey>
        where TEntity : class, IEntity<TKey>
        where TKey : IComparable
    {

    }
}
