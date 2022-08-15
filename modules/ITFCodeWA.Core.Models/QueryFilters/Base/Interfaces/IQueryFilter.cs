namespace ITFCodeWA.Core.Models.QueryFilters.Base.Interfaces
{
    public interface IQueryFilter
    {
        string PropertyName { get; init; }
        string Type { get; }
    }
}