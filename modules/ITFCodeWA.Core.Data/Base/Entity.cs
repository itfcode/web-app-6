using ITFCodeWA.Core.Data.Base.Interface;

namespace ITFCodeWA.Core.Data.Base
{
    public abstract class Entity : IEntity
    {
        public int Id { get; set; }
    }
}
