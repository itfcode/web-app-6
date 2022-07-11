namespace ITFCodeWA.Extensions.DateTimeOffsetExtendors
{
    public static partial class DateTimeOffsetExtensions
    {
        public static DateTimeOffset MondayLast(this DateTimeOffset self)
            => GetLastDayOfWeekForMonth(self, DayOfWeek.Monday);

        public static DateTimeOffset TuesdayLast(this DateTimeOffset self)
            => GetLastDayOfWeekForMonth(self, DayOfWeek.Tuesday);

        public static DateTimeOffset WednesdayLast(this DateTimeOffset self)
            => GetLastDayOfWeekForMonth(self, DayOfWeek.Wednesday);

        public static DateTimeOffset ThursdayLast(this DateTimeOffset self)
            => GetLastDayOfWeekForMonth(self, DayOfWeek.Thursday);

        public static DateTimeOffset FridayLast(this DateTimeOffset self)
            => GetLastDayOfWeekForMonth(self, DayOfWeek.Friday);

        public static DateTimeOffset SaturdayLast(this DateTimeOffset self)
            => GetLastDayOfWeekForMonth(self, DayOfWeek.Saturday);

        public static DateTimeOffset SundayLast(this DateTimeOffset self)
            => GetLastDayOfWeekForMonth(self, DayOfWeek.Sunday);

        private static DateTimeOffset GetLastDayOfWeekForMonth(DateTimeOffset date, DayOfWeek dayOfWeek)
        {
            var last = new DateTimeOffset(date.Year, date.Month, 1, 0, 0, 0, date.Offset).AddMonths(1).AddDays(-1);

            while (last.DayOfWeek != dayOfWeek)
                last = last.AddDays(-1);

            return last.Date;
        }
    }
}