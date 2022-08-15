namespace ITFCodeWA.Extensions.DateTimeExtendors
{
    using System;

    public static partial class DateTimeExtensions
    {
        /// <summary>
        /// Indicates whether this date is Monday
        /// </summary>
        /// <param name="self"> date </param>
        /// <returns>True if date is Modnay </returns>
        public static bool IsMonday(this DateTime self) => self.DayOfWeek == DayOfWeek.Monday;

        /// <summary>
        /// Indicates whether this date is Tuesday
        /// </summary>
        /// <param name="self"> date </param>
        /// <returns>True if date is Tuesday </returns>
        public static bool IsTuesday(this DateTime self) => self.DayOfWeek == DayOfWeek.Tuesday;

        /// <summary>
        /// Indicates whether this date is Wednesday
        /// </summary>
        /// <param name="self"> date </param>
        /// <returns>True if date is Wednesday </returns>
        public static bool IsWednesday(this DateTime self) => self.DayOfWeek == DayOfWeek.Wednesday;

        /// <summary>
        /// Indicates whether this date is Thursday
        /// </summary>
        /// <param name="self"> date </param>
        /// <returns>True if date is Thursday </returns>
        public static bool IsThursday(this DateTime self) => self.DayOfWeek == DayOfWeek.Thursday;

        /// <summary>
        /// Indicates whether this date is Friday
        /// </summary>
        /// <param name="self"> date </param>
        /// <returns>True if date is Friday </returns>
        public static bool IsFriday(this DateTime self) => self.DayOfWeek == DayOfWeek.Friday;

        /// <summary>
        /// Indicates whether this date is Saturday
        /// </summary>
        /// <param name="self"> date </param>
        /// <returns>True if date is Saturday </returns>
        public static bool IsSaturday(this DateTime self) => self.DayOfWeek == DayOfWeek.Saturday;

        /// <summary>
        /// Indicates whether this date is Sunday
        /// </summary>
        /// <param name="self"> date </param>
        /// <returns>True if date is Sunday </returns>
        public static bool IsSunday(this DateTime self) => self.DayOfWeek == DayOfWeek.Sunday;

        /// <summary>
        /// Indicates whether this date is Saturday or Sunday 
        /// </summary>
        /// <param name="self"> date </param>
        /// <returns>True if date is Saturday or </returns>
        public static bool IsWeekEnds(this DateTime self) => self.IsSaturday() || self.IsSunday();
    }
}
