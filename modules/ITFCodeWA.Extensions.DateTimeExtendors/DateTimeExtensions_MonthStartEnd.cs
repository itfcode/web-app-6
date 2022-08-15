namespace ITFCodeWA.Extensions.DateTimeExtendors
{
    using System;

    public static partial class DateTimeExtensions
    {
        public static DateTime MonthStartAt(this DateTime self, int months) => GetMonthStart(self).AddMonths(months);
        public static DateTime MonthStart(this DateTime self) => self.MonthStartAt(0);
        public static DateTime MonthStartPrev(this DateTime self) => self.MonthStartAt(-1);
        public static DateTime MonthStartNext(this DateTime self) => self.MonthStartAt(1);

        public static DateTime MonthEndAt(this DateTime self, int months) => self.MonthStartAt(months + 1).AddTicks(-1);
        public static DateTime MonthEnd(this DateTime self) => self.MonthEndAt(0);
        public static DateTime MonthEndPrev(this DateTime self) => self.MonthEndAt(-1);
        public static DateTime MonthEndNext(this DateTime self) => self.MonthEndAt(1);

        private static DateTime GetMonthStart(DateTime date) => new DateTime(date.Year, date.Month, 1);
    }
}
