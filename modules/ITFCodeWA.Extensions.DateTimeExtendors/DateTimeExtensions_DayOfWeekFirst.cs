namespace ITFCodeWA.Extensions.DateTimeExtendors
{
    using System;

    public static partial class DateTimeExtensions
    {
        /// <summary>
        /// Gets date of first Monday of month by date 
        /// </summary>
        /// <param name="self">Date of Month</param>
        /// <returns>Date of first Monday</returns>
        public static DateTime MondayFirst(this DateTime self) => GetFirstDayOfWeekForMonth(self, DayOfWeek.Monday);

        /// <summary>
        /// Gets date of first Tuesday of month by date 
        /// </summary>
        /// <param name="self">Date of Month</param>
        /// <returns>Date of first Tuesday</returns>
        public static DateTime TuesdayFirst(this DateTime self) => GetFirstDayOfWeekForMonth(self, DayOfWeek.Tuesday);

        /// <summary>
        /// Gets date of first Wednesday of month by date 
        /// </summary>
        /// <param name="self">Date of Month</param>
        /// <returns>Date of first Wednesday</returns>
        public static DateTime WednesdayFirst(this DateTime self) => GetFirstDayOfWeekForMonth(self, DayOfWeek.Wednesday);

        /// <summary>
        /// Gets date of first Thursday of month by date 
        /// </summary>
        /// <param name="self">Date of Month</param>
        /// <returns>Date of first Thursday</returns>
        public static DateTime ThursdayFirst(this DateTime self) => GetFirstDayOfWeekForMonth(self, DayOfWeek.Thursday);

        /// <summary>
        /// Gets date of first Friday of month by date 
        /// </summary>
        /// <param name="self">Date of Month</param>
        /// <returns>Date of first Friday</returns>
        public static DateTime FridayFirst(this DateTime self) => GetFirstDayOfWeekForMonth(self, DayOfWeek.Friday);

        /// <summary>
        /// Gets date of first Saturday of month by date 
        /// </summary>
        /// <param name="self">Date of Month</param>
        /// <returns>Date of first Saturday</returns>
        public static DateTime SaturdayFirst(this DateTime self) => GetFirstDayOfWeekForMonth(self, DayOfWeek.Saturday);

        /// <summary>
        /// Gets date of first Sunday of month by date 
        /// </summary>
        /// <param name="self">Date of Month</param>
        /// <returns>Date of first Sunday</returns>
        public static DateTime SundayFirst(this DateTime self) => GetFirstDayOfWeekForMonth(self, DayOfWeek.Sunday);

        private static DateTime GetFirstDayOfWeekForMonth(DateTime date, DayOfWeek dayOfWeek)
        {
            var first = new DateTime(date.Year, date.Month, 1);

            while (first.DayOfWeek != dayOfWeek)
                first = first.AddDays(1);

            return first.Date;
        }
    }
}
