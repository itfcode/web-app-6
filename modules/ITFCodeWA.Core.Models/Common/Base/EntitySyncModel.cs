using ITFCodeWA.Core.Models.Common.Base.Interfaces;

namespace ITFCodeWA.Core.Models.Common.Base
{
    public abstract class EntitySyncModel : IEntitySyncModel
    {
        public Guid Id { get; set; }
    }
}