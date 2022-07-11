namespace ITFCodeWA.Extensions.DateTimeNullableExtendors
{
    public static partial class DateTimeNullableExtensions
    {
        public static bool IsAM(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(TotalSeconds), d => d.TotalMinutes() < (12 * 60), throwIfNull);

        public static bool IsPM(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(TotalSeconds), d => !d.IsAM(), throwIfNull);
    }
}