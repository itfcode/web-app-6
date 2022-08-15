namespace ITFCodeWA.Extensions.DateTimeOffsetExtendors
{
    public static partial class DateTimeOffsetExtensions
    {
        public static DateTimeOffset MondayFirst(this DateTimeOffset self)
            => GetFirstDayOfWeekForMonth(self, DayOfWeek.Monday);

        public static DateTimeOffset TuesdayFirst(this DateTimeOffset self)
            => GetFirstDayOfWeekForMonth(self, DayOfWeek.Tuesday);

        public static DateTimeOffset WednesdayFirst(this DateTimeOffset self)
            => GetFirstDayOfWeekForMonth(self, DayOfWeek.Wednesday);

        public static DateTimeOffset ThursdayFirst(this DateTimeOffset self)
            => GetFirstDayOfWeekForMonth(self, DayOfWeek.Thursday);

        public static DateTimeOffset FridayFirst(this DateTimeOffset self)
            => GetFirstDayOfWeekForMonth(self, DayOfWeek.Friday);

        public static DateTimeOffset SaturdayFirst(this DateTimeOffset self)
            => GetFirstDayOfWeekForMonth(self, DayOfWeek.Saturday);

        public static DateTimeOffset SundayFirst(this DateTimeOffset self)
            => GetFirstDayOfWeekForMonth(self, DayOfWeek.Sunday);

        private static DateTimeOffset GetFirstDayOfWeekForMonth(DateTimeOffset date, DayOfWeek dayOfWeek)
        {
            var first = new DateTimeOffset(date.Year, date.Month, 1, 0, 0, 0, date.Offset);

            while (first.DayOfWeek != dayOfWeek)
                first = first.AddDays(1);

            return first.Date;
        }
    }
}