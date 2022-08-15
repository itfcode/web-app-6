namespace ITFCodeWA.Extensions.DateTimeNullableExtendors
{
    public static partial class DateTimeNullableExtensions
    {
        public static bool IsMonday(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(IsMonday), d => d.Value.DayOfWeek == DayOfWeek.Monday, throwIfNull);

        public static bool IsTuesday(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(IsTuesday), d => d.Value.DayOfWeek == DayOfWeek.Tuesday, throwIfNull);

        public static bool IsWednesday(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(IsWednesday), d => d.Value.DayOfWeek == DayOfWeek.Wednesday, throwIfNull);

        public static bool IsThursday(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(IsThursday), d => d.Value.DayOfWeek == DayOfWeek.Thursday, throwIfNull);

        public static bool IsFriday(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(IsFriday), d => d.Value.DayOfWeek == DayOfWeek.Friday, throwIfNull);

        public static bool IsSaturday(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(IsSaturday), d => d.Value.DayOfWeek == DayOfWeek.Saturday, throwIfNull);

        public static bool IsSunday(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(IsSunday), d => d.Value.DayOfWeek == DayOfWeek.Sunday, throwIfNull);

        public static bool IsWeekEnds(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(IsSunday), d => d.IsSaturday() || d.IsSunday(), throwIfNull);
    }
}