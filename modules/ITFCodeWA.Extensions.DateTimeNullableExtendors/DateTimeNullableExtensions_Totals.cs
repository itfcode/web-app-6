namespace ITFCodeWA.Extensions.DateTimeNullableExtendors
{
    public static partial class DateTimeNullableExtensions
    {
        public static int TotalMinutes(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(TotalMinutes), d => d.Value.Minute + d.Value.Hour * 60, throwIfNull);

        public static int TotalSeconds(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(TotalSeconds), d => d.TotalMinutes() * 60 + d.Value.Second, throwIfNull);

        public static int TotalMilliseconds(this DateTime? self, bool throwIfNull = true)
            => Exec(self, nameof(TotalMilliseconds), d => d.TotalSeconds() * 1000 + d.Value.Millisecond, throwIfNull);

        private static int Exec(DateTime? date, string methodName, Func<DateTime?, int> expression, bool throwIfNull = true)
        {
            if (!date.HasValue)
                if (throwIfNull)
                    throw new ArgumentNullException(nameof(date), $"Method '{methodName}'()");
                else
                    return 0;
            else
                return expression(date);
        }
    }
}