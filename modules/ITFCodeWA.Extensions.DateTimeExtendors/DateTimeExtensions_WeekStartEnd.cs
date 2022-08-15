namespace ITFCodeWA.Extensions.DateTimeExtendors
{
    using System;

    public static partial class DateTimeExtensions
    {
        public static DateTime WeekStartAt(this DateTime self, int weeks) => GetWeekStart(self).AddDays(weeks * 7);
        public static DateTime WeekStart(this DateTime self) => self.WeekStartAt(0);
        public static DateTime WeekStartPrev(this DateTime self) => self.WeekStartAt(-1);     
        public static DateTime WeekStartNext(this DateTime self) => self.WeekStartAt(1);

        public static DateTime WeekEndAt(this DateTime self, int weeks) => self.WeekStartAt(weeks + 1).AddTicks(-1);
        public static DateTime WeekEnd(this DateTime self) => self.WeekEndAt(0);
        public static DateTime WeekEndPrev(this DateTime self) => self.WeekEndAt(-1);
        public static DateTime WeekEndNext(this DateTime self) => self.WeekEndAt(1);

        private static DateTime GetWeekStart(DateTime date)
        {
            var dayMinus = date.DayOfWeek switch
            {
                DayOfWeek.Monday => 0,
                DayOfWeek.Tuesday => 1,
                DayOfWeek.Wednesday => 2,
                DayOfWeek.Thursday => 3,
                DayOfWeek.Friday => 4,
                DayOfWeek.Saturday => 5,
                DayOfWeek.Sunday => 6,
                _ => throw new ArgumentOutOfRangeException(nameof(date))
            };
            return date.AddDays(-1 * dayMinus).Date;
        }
    }
}
