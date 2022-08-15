using ITFCodeWA.Core.Models.QueryFilters.Diapason;
using ITFCodeWA.Core.Services.FiltersHandlers.Diapason.Base;

namespace ITFCodeWA.Core.Services.FiltersHandlers.Diapason
{
    public class NumericDiapasonFilterHandler : DiapasonFilterHandler<NumericDiapasonFilter, double>
    {
        #region Constructors 

        public NumericDiapasonFilterHandler(NumericDiapasonFilter filter) : base(filter) { }

        #endregion
    }
}