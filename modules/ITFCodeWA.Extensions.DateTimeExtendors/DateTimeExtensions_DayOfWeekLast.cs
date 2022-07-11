namespace ITFCodeWA.Extensions.DateTimeExtendors
{
    using System;

    public static partial class DateTimeExtensions
    {
        /// <summary>
        /// Gets date of last Monday of month from date 
        /// </summary>
        /// <param name="self">Date of Month</param>
        /// <returns>Date of last Monday</returns>
        public static DateTime MondayLast(this DateTime self) => GetLastDayOfWeekForMonth(self, DayOfWeek.Monday);

        /// <summary>
        /// Gets date of last Tuesday of month from date 
        /// </summary>
        /// <param name="self">Date of Month</param>
        /// <returns>Date of last Tuesday</returns>
        public static DateTime TuesdayLast(this DateTime self) => GetLastDayOfWeekForMonth(self, DayOfWeek.Tuesday);

        /// <summary>
        /// Gets date of last Wednesday of month from date 
        /// </summary>
        /// <param name="self">Date of Month</param>
        /// <returns>Date of last Wednesday</returns>
        public static DateTime WednesdayLast(this DateTime self) => GetLastDayOfWeekForMonth(self, DayOfWeek.Wednesday);

        /// <summary>
        /// Gets date of last Thursday of month from date 
        /// </summary>
        /// <param name="self">Date of Month</param>
        /// <returns>Date of last Thursday</returns>
        public static DateTime ThursdayLast(this DateTime self) => GetLastDayOfWeekForMonth(self, DayOfWeek.Thursday);

        /// <summary>
        /// Gets date of last Friday of month from date 
        /// </summary>
        /// <param name="self">Date of Month</param>
        /// <returns>Date of last Friday</returns>
        public static DateTime FridayLast(this DateTime self) => GetLastDayOfWeekForMonth(self, DayOfWeek.Friday);

        /// <summary>
        /// Gets date of last Saturday of month from date 
        /// </summary>
        /// <param name="self">Date of Month</param>
        /// <returns>Date of last Saturday</returns>
        public static DateTime SaturdayLast(this DateTime self) => GetLastDayOfWeekForMonth(self, DayOfWeek.Saturday);

        /// <summary>
        /// Gets date of last Sunday of month from date 
        /// </summary>
        /// <param name="self">Date of Month</param>
        /// <returns>Date of last Sunday</returns>
        public static DateTime SundayLast(this DateTime self) => GetLastDayOfWeekForMonth(self, DayOfWeek.Sunday);

        private static DateTime GetLastDayOfWeekForMonth(DateTime date, DayOfWeek dayOfWeek)
        {
            var last = new DateTime(date.Year, date.Month, 1).AddMonths(1).AddDays(-1);

            while (last.DayOfWeek != dayOfWeek)
                last = last.AddDays(-1);

            return last.Date;
        }
    }
}
