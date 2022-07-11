namespace ITFCodeWA.Core.Data.Base.Interface
{
    public interface IEntity<TKey> where TKey : IComparable
    {
        TKey Id { get; set; }
    }

    public interface IEntity : IEntity<int>
    {
    }

    public interface IEntitySync : IEntity<Guid>
    {
    }
}
