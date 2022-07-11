namespace ITFCodeWA.Extensions.DateTimeOffsetExtendors
{
    public static partial class DateTimeOffsetExtensions
    {
        public static DateTimeOffset WeekStartAt(this DateTimeOffset self, int weeks) => GetWeekStart(self).AddDays(weeks * 7);
        public static DateTimeOffset WeekStart(this DateTimeOffset self) => self.WeekStartAt(0);
        public static DateTimeOffset WeekStartPrev(this DateTimeOffset self) => self.WeekStartAt(-1);
        public static DateTimeOffset WeekStartNext(this DateTimeOffset self) => self.WeekStartAt(1);

        public static DateTimeOffset WeekEndAt(this DateTimeOffset self, int weeks) => self.WeekStartAt(weeks + 1).AddTicks(-1);
        public static DateTimeOffset WeekEnd(this DateTimeOffset self) => self.WeekEndAt(0);
        public static DateTimeOffset WeekEndPrev(this DateTimeOffset self) => self.WeekEndAt(-1);
        public static DateTimeOffset WeekEndNext(this DateTimeOffset self) => self.WeekEndAt(1);

        private static DateTimeOffset GetWeekStart(DateTimeOffset date)
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