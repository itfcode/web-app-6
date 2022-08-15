namespace ITFCodeWA.Extensions.DateTimeNullableExtendors
{
    public static partial class DateTimeNullableExtensions
    {
        public static DateTime? DayStartAt(this DateTime? self, int days, bool throwIfNull = true)
            => Exec(self, nameof(DayStartAt), x => x.Value.Date.AddDays(days), throwIfNull);

        public static DateTime? DayStart(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(DayStart), x => x.DayStartAt(0), throwIfNull);

        public static DateTime? DayStartPrev(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(DayStartPrev), x => x.DayStartAt(-1), throwIfNull);

        public static DateTime? DayStartNext(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(DayStartNext), x => x.DayStartAt(1), throwIfNull);

        public static DateTime? DayEndAt(this DateTime? self, int days, bool throwIfNull = true)
            => Exec(self, nameof(DayEndAt), x => x.DayStartAt(days + 1).AddTicks(-1), throwIfNull);

        public static DateTime? DayEnd(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(DayEnd), x => x.DayEndAt(0), throwIfNull);

        public static DateTime? DayEndPrev(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(DayEndPrev), x => x.DayEndAt(-1), throwIfNull);

        public static DateTime? DayEndNext(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(DayEndNext), x => x.DayEndAt(1), throwIfNull);
    }
}