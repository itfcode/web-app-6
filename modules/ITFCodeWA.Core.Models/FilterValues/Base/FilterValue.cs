using ITFCodeWA.Core.Models.FilterValues.Base.Interfaces;

namespace ITFCodeWA.Core.Models.FilterValues.Base
{
    public abstract class FilterValue : IFilterValue
    {
        public string Label { get; set; }

        public bool Included { get; set; } = true;
    }

    public abstract class FilterValue<T> : FilterValue
    {
        public T Value { get; set; } = default(T);
    }
}
