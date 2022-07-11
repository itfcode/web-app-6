using ITFCodeWA.Core.Data.Base.Interface;

namespace ITFCodeWA.Core.Data.Base
{
    public abstract class EntitySync : IEntitySync
    {
        public Guid Id { get; set; }
    }
}
