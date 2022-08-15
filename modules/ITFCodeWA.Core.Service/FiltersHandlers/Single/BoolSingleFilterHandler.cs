using ITFCodeWA.Core.Models.QueryFilters.Single;
using ITFCodeWA.Core.Services.FiltersHandlers.Single.Base;

namespace ITFCodeWA.Core.Services.FiltersHandlers.Single
{
    public class BoolSingleFilterHandler : SingleFilterHandler<BoolSingleFilter, bool>
    {
        #region Constructors

        public BoolSingleFilterHandler(BoolSingleFilter filter) : base(filter) { }

        #endregion
    }
}
