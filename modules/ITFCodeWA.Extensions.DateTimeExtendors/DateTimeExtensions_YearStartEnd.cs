namespace ITFCodeWA.Extensions.DateTimeExtendors
{
    using System;

    public static partial class DateTimeExtensions
    {
        public static DateTime YearStartAt(this DateTime self, int years) => GetYearStart(self).AddYears(years);
        public static DateTime YearStart(this DateTime self) => self.YearStartAt(0);
        public static DateTime YearStartPrev(this DateTime self) => self.YearStartAt(-1);
        public static DateTime YearStartNext(this DateTime self) => self.YearStartAt(1);

        public static DateTime YearEndAt(this DateTime self, int years) => self.YearStartAt(years + 1).AddTicks(-1);
        public static DateTime YearEnd(this DateTime self) => self.YearEndAt(0);
        public static DateTime YearEndPrev(this DateTime self) => self.YearEndAt(-1);
        public static DateTime YearEndNext(this DateTime self) => self.YearEndAt(1);

        public static DateTime GetYearStart(DateTime date) => new DateTime(date.Year, 1, 1);
    }
}
