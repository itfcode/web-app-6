namespace ITFCodeWA.Extensions.DateTimeNullableExtendors
{
    public static partial class DateTimeNullableExtensions
    {
        public static DateTime? WeekStartAt(this DateTime? self, int weeks, bool throwIfNull = true)
            => Exec(self, nameof(WeekStartAt), d => GetWeekStart(d).Value.AddDays(weeks * 7), throwIfNull);

        public static DateTime? WeekStart(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(WeekStart), d => d.WeekStartAt(0), throwIfNull);

        public static DateTime? WeekStartPrev(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(WeekStartPrev), d => d.WeekStartAt(-1), throwIfNull);

        public static DateTime? WeekStartNext(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(WeekStartNext), d => d.WeekStartAt(1), throwIfNull);

        public static DateTime? WeekEndAt(this DateTime? self, int weeks, bool throwIfNull = true)
            => Exec(self, nameof(WeekEndAt), d => GetWeekEnd(d).Value.AddDays(weeks * 7), throwIfNull);

        public static DateTime? WeekEnd(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(WeekEnd), d => d.WeekEndAt(0), throwIfNull);

        public static DateTime? WeekEndPrev(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(WeekEndPrev), d => d.WeekEndAt(-1), throwIfNull);

        public static DateTime? WeekEndNext(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(WeekEndNext), d => d.WeekEndAt(1), throwIfNull);

        private static DateTime? GetWeekStart(DateTime? date, bool throwIfNull = true)
        {
            if (!date.HasValue && throwIfNull)
                throw new ArgumentNullException(nameof(date), $"Method GetWeekStart()");
            else if (!date.HasValue)
                return date;

            var dayMinus = date.Value.DayOfWeek switch
            {
                DayOfWeek.Monday => 0,
                DayOfWeek.Tuesday => 1,
                DayOfWeek.Wednesday => 2,
                DayOfWeek.Thursday => 3,
                DayOfWeek.Friday => 4,
                DayOfWeek.Saturday => 5,
                DayOfWeek.Sunday => 6,
                _ => throw new ArgumentOutOfRangeException()
            };

            return date.Value.AddDays(-dayMinus).Date;
        }

        private static DateTime? GetWeekEnd(DateTime? date, bool throwIfNull = true) 
        {
            if (!date.HasValue && throwIfNull)
                throw new ArgumentNullException(nameof(date), $"Method {nameof(GetWeekEnd)}()");
            else if (!date.HasValue)
                return date;

            return GetWeekStart(date).Value.AddDays(7).AddTicks(-1);
        }
    }
}