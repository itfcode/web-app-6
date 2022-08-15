using ITFCodeWA.Core.Models.QueryFilters.Single;
using ITFCodeWA.Core.Services.FiltersHandlers.Single.Base;

namespace ITFCodeWA.Core.Services.FiltersHandlers.Single
{
    public class GuidSingleFilterHandler : SingleFilterHandler<GuidSingleFilter, Guid>
    {
        #region Constructors

        public GuidSingleFilterHandler(GuidSingleFilter filter) : base(filter) { }

        #endregion
    }
}
