namespace ITFCodeWA.Extensions.DateTimeNullableExtendors
{
    public static partial class DateTimeNullableExtensions
    {
        public static DateTime? MondayFirst(this DateTime? self, bool throwIfNull = true)
            => GetFirstDayOfWeekForMonth(self, DayOfWeek.Monday, throwIfNull);

        public static DateTime? TuesdayFirst(this DateTime? self, bool throwIfNull = true)
            => GetFirstDayOfWeekForMonth(self, DayOfWeek.Tuesday, throwIfNull);

        public static DateTime? WednesdayFirst(this DateTime? self, bool throwIfNull = true)
            => GetFirstDayOfWeekForMonth(self, DayOfWeek.Wednesday, throwIfNull);

        public static DateTime? ThursdayFirst(this DateTime? self, bool throwIfNull = true)
            => GetFirstDayOfWeekForMonth(self, DayOfWeek.Thursday, throwIfNull);

        public static DateTime? FridayFirst(this DateTime? self, bool throwIfNull = true)
            => GetFirstDayOfWeekForMonth(self, DayOfWeek.Friday, throwIfNull);

        public static DateTime? SaturdayFirst(this DateTime? self, bool throwIfNull = true)
            => GetFirstDayOfWeekForMonth(self, DayOfWeek.Saturday, throwIfNull);

        public static DateTime? SundayFirst(this DateTime? self, bool throwIfNull = true)
            => GetFirstDayOfWeekForMonth(self, DayOfWeek.Sunday, throwIfNull);

        private static DateTime? GetFirstDayOfWeekForMonth(DateTime? date, DayOfWeek dayOfWeek, bool throwIfNull = true)
        {
            if (!date.HasValue && throwIfNull)
                throw new ArgumentNullException(nameof(date), $"Method {GetFirstDayOfWeekForMonth}()");
            else if (!date.HasValue)
                return date;

            var first = new DateTime(date.Value.Year, date.Value.Month, 1);

            while (first.DayOfWeek != dayOfWeek)
                first = first.AddDays(1);

            return first.Date;
        }
    }
}