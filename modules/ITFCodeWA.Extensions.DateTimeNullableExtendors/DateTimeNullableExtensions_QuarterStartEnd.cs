namespace ITFCodeWA.Extensions.DateTimeNullableExtendors
{
    public static partial class DateTimeNullableExtensions
    {
        public static DateTime? QuarterStartAt(this DateTime? self, int quarters, bool throwIfNull = true)
            => Exec(self, nameof(QuarterStartAt), d => GetQuarterStart(d).Value.AddMonths(quarters * 3), throwIfNull);

        public static DateTime? QuarterStart(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(QuarterStart), d => d.QuarterStartAt(0), throwIfNull);

        public static DateTime? QuarterStartPrev(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(QuarterStartPrev), d => d.QuarterStartAt(-1), throwIfNull);

        public static DateTime? QuarterStartNext(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(QuarterStartNext), d => d.QuarterStartAt(1), throwIfNull);

        public static DateTime? QuarterEndAt(this DateTime? self, int quarters, bool throwIfNull = true)
            => Exec(self, nameof(QuarterEndAt), d => d.QuarterStartAt(quarters + 1).Value.AddTicks(-1), throwIfNull);

        public static DateTime? QuarterEnd(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(QuarterEnd), d => d.QuarterEndAt(0), throwIfNull);

        public static DateTime? QuarterEndPrev(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(QuarterEndPrev), d => d.QuarterEndAt(-1), throwIfNull);

        public static DateTime? QuarterEndNext(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(QuarterEndNext), d => d.QuarterEndAt(1), throwIfNull);

        private static DateTime? GetQuarterStart(DateTime? date, bool throwIfNull = true)
        {
            if (!date.HasValue && throwIfNull)
                throw new ArgumentNullException(nameof(date), $"Method {GetQuarterStart}()");
            else if (!date.HasValue)
                return date;

            var quarterNumber = date.Value.Month switch
            {
                1 or 2 or 3 => 1,
                4 or 5 or 6 => 2,
                7 or 8 or 9 => 3,
                10 or 11 or 12 => 4,
                _ => throw new ArgumentOutOfRangeException()
            };

            return new DateTime(date.Value.Year, ((quarterNumber - 1) * 3) + 1, 1);
        }
    }
}