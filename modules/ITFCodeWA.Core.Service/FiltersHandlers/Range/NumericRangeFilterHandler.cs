using ITFCodeWA.Core.Models.QueryFilters.Range;
using ITFCodeWA.Core.Services.FiltersHandlers.Range.Base;

namespace ITFCodeWA.Core.Services.FiltersHandlers.Range
{
    public class NumericRangeFilterHandler : RangeFilterHandler<NumericRangeFilter, double>
    {
        #region Constructions

        public NumericRangeFilterHandler(NumericRangeFilter filter) : base(filter) { }

        #endregion
    }
}