namespace ITFCodeWA.Core.Models.Common.Base.Interfaces
{
    public interface IModel<TKey> where TKey : IComparable
    {
        TKey Id { get; set; }
    }
}
