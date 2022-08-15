namespace ITFCodeWA.Extensions.DateTimeNullableExtendors
{
    public static partial class DateTimeNullableExtensions
    {
        public static DateTime? YearStartAt(this DateTime? self, int years, bool throwIfNull = true)
            => Exec(self, nameof(YearStartAt), d => GetYearStart(d).Value.AddYears(years), throwIfNull);

        public static DateTime? YearStart(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(YearStart), d => d.YearStartAt(0), throwIfNull);

        public static DateTime? YearStartPrev(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(YearStart), d => d.YearStartAt(-1), throwIfNull);

        public static DateTime? YearStartNext(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(YearStart), d => d.YearStartAt(1), throwIfNull);

        public static DateTime? YearEndAt(this DateTime? self, int years, bool throwIfNull = true)
            => Exec(self, nameof(YearEndAt), d => d.YearEndAt(years + 1).Value.AddTicks(-1), throwIfNull);

        public static DateTime? YearEnd(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(YearEnd), d => d.YearEndAt(0), throwIfNull);

        public static DateTime? YearEndPrev(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(YearEndPrev), d => d.YearEndAt(-1), throwIfNull);

        public static DateTime? YearEndNext(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(YearEndNext), d => d.YearEndAt(1), throwIfNull);

        private static DateTime? GetYearStart(DateTime? date, bool throwIfNull = true)
        {
            if (!date.HasValue && throwIfNull)
                throw new ArgumentNullException(nameof(date), $"Method {nameof(GetYearStart)}()");
            else if (!date.HasValue)
                return date;

            return new DateTime(date.Value.Year, 1, 1);
        }
    }
}