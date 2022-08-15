namespace ITFCodeWA.Extensions.DateTimeNullableExtendors
{
    public static partial class DateTimeNullableExtensions
    {
        public static DateTime? MonthStartAt(this DateTime? self, int months, bool throwIfNull = true)
            => Exec(self, nameof(MonthStartAt), d => GetMonthStart(d).Value.AddMonths(months), throwIfNull);

        public static DateTime? MonthStart(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(MonthStart), d => d.MonthStartAt(0), throwIfNull);

        public static DateTime? MonthStartPrev(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(MonthStartPrev), d => d.MonthStartAt(-1), throwIfNull);

        public static DateTime? MonthStartNext(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(MonthStartNext), d => d.MonthStartAt(1), throwIfNull);

        public static DateTime? MonthEndAt(this DateTime? self, int months, bool throwIfNull = true)
            => Exec(self, nameof(MonthEndAt), d => d.MonthStartAt(months + 1).Value.AddTicks(-1), throwIfNull);

        public static DateTime? MonthEnd(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(MonthEndAt), d => d.MonthEndAt(0), throwIfNull);

        public static DateTime? MonthEndPrev(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(MonthEndAt), d => d.MonthEndAt(-1), throwIfNull);

        public static DateTime? MonthEndNext(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(MonthEndAt), d => d.MonthEndAt(1), throwIfNull);

        private static DateTime? GetMonthStart(DateTime? date, bool throwIfNull = true)
        {
            if (!date.HasValue && throwIfNull)
                throw new ArgumentNullException(nameof(date), $"Method {GetMonthStart}()");
            else if (!date.HasValue)
                return date;

            return new DateTime(date.Value.Year, date.Value.Month, 1);
        }
    }
}