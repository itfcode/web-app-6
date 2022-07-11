namespace ITFCodeWA.Extensions.DateTimeNullableExtendors
{
    public static partial class DateTimeNullableExtensions
    {
        public static DateTime? Add(this DateTime? self, TimeSpan value, bool throwIfNull = true)
            => Exec(self, nameof(Add), x => x.Value.Add(value), throwIfNull);

        public static DateTime? AddTicks(this DateTime? self, long value, bool throwIfNull = true)
            => Exec(self, nameof(AddTicks), x => x.Value.AddTicks(value), throwIfNull);

        public static DateTime? AddMilliseconds(this DateTime? self, double value, bool throwIfNull = true)
            => Exec(self, nameof(AddMilliseconds), x => x.Value.AddMilliseconds(value), throwIfNull);

        public static DateTime? AddSeconds(this DateTime? self, double value, bool throwIfNull = true)
            => Exec(self, nameof(AddSeconds), x => x.Value.AddSeconds(value), throwIfNull);

        public static DateTime? AddMinutes(this DateTime? self, double value, bool throwIfNull = true)
            => Exec(self, nameof(AddMinutes), x => x.Value.AddMinutes(value), throwIfNull);

        public static DateTime? AddHours(this DateTime? self, double value, bool throwIfNull = true)
            => Exec(self, nameof(AddHours), x => x.Value.AddHours(value), throwIfNull);

        public static DateTime? AddDays(this DateTime? self, double value, bool throwIfNull = true)
            => Exec(self, nameof(AddDays), x => x.Value.AddDays(value), throwIfNull);

        public static DateTime? AddMonths(this DateTime? self, int months, bool throwIfNull = true)
            => Exec(self, nameof(AddMonths), x => x.Value.AddMonths(months), throwIfNull);

        public static DateTime? AddYears(this DateTime? self, int value, bool throwIfNull = true)
            => Exec(self, nameof(AddYears), x => x.Value.AddYears(value), throwIfNull);
    }
}