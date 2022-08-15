namespace ITFCodeWA.Extensions.DateTimeNullableExtendors
{
    public static partial class DateTimeNullableExtensions
    {
        public static DateTime CopyTime(this DateTime self, DateTime source, bool throwIfNull = true)
            => throw new NotImplementedException();

        public static DateTime ResetMilliseconds(this DateTime self, bool throwIfNull = true)
            => throw new NotImplementedException();

        public static DateTime ResetSeconds(this DateTime self, bool throwIfNull = true)
            => throw new NotImplementedException();

        public static DateTime ResetMinutes(this DateTime self, bool throwIfNull = true)
            => throw new NotImplementedException();

        /// <summary>
        /// Helps to execute the method 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="methodName"></param>
        /// <param name="expression"></param>
        /// <param name="throwIfNull"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        private static DateTime? Exec(DateTime? date, string methodName, Func<DateTime?, DateTime> expression, bool throwIfNull = true)
        {
            if (!date.HasValue)
                if (throwIfNull)
                    throw new ArgumentNullException(nameof(date), $"Method '{methodName}'()");
                else
                    return date;
            else
                return expression(date);
        }

        /// <summary>
        /// Helps to execute the method 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="methodName"></param>
        /// <param name="expression"></param>
        /// <param name="throwIfNull"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        private static DateTime? Exec(DateTime? date, string methodName, Func<DateTime?, DateTime?> expression, bool throwIfNull = true)
        {
            if (!date.HasValue)
                if (throwIfNull)
                    throw new ArgumentNullException(nameof(date), $"Method '{methodName}'()");
                else
                    return date;
            else
                return expression(date);
        }

        /// <summary>
        /// Helps to execute the method
        /// </summary>
        /// <param name="date"></param>
        /// <param name="methodName"></param>
        /// <param name="expression"></param>
        /// <param name="throwIfNull"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        private static bool Exec(DateTime? date, string methodName, Func<DateTime?, bool> expression, bool throwIfNull = true)
        {
            if (!date.HasValue)
                if (throwIfNull)
                    throw new ArgumentNullException(nameof(date), $"Method '{methodName}'()");
                else
                    return false;
            else
                return expression(date);
        }
    }
}