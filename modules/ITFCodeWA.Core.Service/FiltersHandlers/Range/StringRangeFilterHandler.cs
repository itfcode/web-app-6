using ITFCodeWA.Core.Models.QueryFilters.Range;
using ITFCodeWA.Core.Services.FiltersHandlers.Range.Base;

namespace ITFCodeWA.Core.Services.FiltersHandlers.Range
{
    public class StringRangeFilterHandler : RangeFilterHandler<StringRangeFilter, string>
    {
        #region Constructions

        public StringRangeFilterHandler(StringRangeFilter filter) : base(filter) { }

        #endregion
    }
}