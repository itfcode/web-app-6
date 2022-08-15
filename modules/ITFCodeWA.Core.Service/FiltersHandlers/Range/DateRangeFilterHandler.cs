using ITFCodeWA.Core.Models.QueryFilters.Range;
using ITFCodeWA.Core.Services.FiltersHandlers.Range.Base;

namespace ITFCodeWA.Core.Services.FiltersHandlers.Range
{
    public class DateRangeFilterHandler : RangeFilterHandler<DateRangeFilter, DateTimeOffset>
    {
        #region Constructions

        public DateRangeFilterHandler(DateRangeFilter filter) : base(filter) { }

        #endregion
    }
}