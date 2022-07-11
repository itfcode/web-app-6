namespace ITFCodeWA.Core.Models.FilterValues.Base.Interfaces
{
    public interface IFilterValue
    {
        string Label { get; set; }
        bool Included { get; set; }
    }

    public interface IFilterValue<T> : IFilterValue
    {
        T Value { get; set; }
    }
}
