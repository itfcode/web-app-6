using ITFCodeWA.Core.Models.QueryFilters.Range;
using ITFCodeWA.Core.Services.FiltersHandlers.Range.Base;

namespace ITFCodeWA.Core.Services.FiltersHandlers.Range
{
    public class GuidRangeFilterHandler : RangeFilterHandler<GuidRangeFilter, Guid>
    {
        #region Constructions

        public GuidRangeFilterHandler(GuidRangeFilter filter) : base(filter) { }

        #endregion
    }
}