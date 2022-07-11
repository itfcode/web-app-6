namespace ITFCodeWA.Extensions.DateTimeExtendors
{
    using System;

    public static partial class DateTimeExtensions
    {
        public static DateTime QuarterStartAt(this DateTime self, int quarters) => GetQuaterStart(self).AddMonths(quarters * 3);
        public static DateTime QuarterStart(this DateTime self) => self.QuarterStartAt(0);
        public static DateTime QuarterStartPrev(this DateTime self) => self.QuarterStartAt(-1);
        public static DateTime QuarterStartNext(this DateTime self) => self.QuarterStartAt(1);

        public static DateTime QuarterEnd(this DateTime self) => self.QuarterStartAt(1).AddTicks(-1);
        public static DateTime QuarterEndAt(this DateTime self, int quarters) => self.QuarterStartAt(quarters + 1).AddTicks(-1);
        public static DateTime QuarterEndPrev(this DateTime self) => self.QuarterEndAt(-1);
        public static DateTime QuarterEndNext(this DateTime self) => self.QuarterEndAt(1);

        private static DateTime GetQuaterStart(DateTime date)
        {
            var quarterNumber = date.Month switch
            {
                1 or 2 or 3 => 0,
                4 or 5 or 6 => 1,
                7 or 8 or 9 => 2,
                10 or 11 or 12 => 3,
                _ => throw new NotSupportedException($"Number of month is greater then 12"),
            };

            return new DateTime(date.Year, quarterNumber * 3 + 1, 1);
        }
    }
}
