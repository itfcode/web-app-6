using ITFCodeWA.Core.Models.QueryFilters.Diapason;
using ITFCodeWA.Core.Services.FiltersHandlers.Diapason.Base;

namespace ITFCodeWA.Core.Services.FiltersHandlers.Diapason
{
    public class DateDiapasonFilterHandler : DiapasonFilterHandler<DateDiapasonFilter, DateTimeOffset>
    {
        #region Constructors 

        public DateDiapasonFilterHandler(DateDiapasonFilter filter) : base(filter)
        {
        }

        #endregion

        #region Private & Protected Methods 

        protected override DateTimeOffset GetDiapasonStart() => _filter.From.Date;

        protected override DateTimeOffset GetDiapasonFinish() => _filter.To.Date.AddDays(1).AddMilliseconds(-1);

        #endregion
    }
}