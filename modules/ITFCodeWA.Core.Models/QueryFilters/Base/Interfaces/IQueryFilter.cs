namespace ITFCodeWA.Core.Models.QueryFilters.Interfaces
{
    public interface IQueryFilter
    {
        string PropertyName { get; init; }
        string Type { get; }
    }

    public interface IQueryFilter<T> : IQueryFilter
    {
        T Value { get; init; }
    }
}