namespace ITFCodeWA.Extensions.DateTimeOffsetExtendors
{
    public static partial class DateTimeOffsetExtensions
    {
        public static bool IsMonday(this DateTimeOffset self) => self.DayOfWeek == DayOfWeek.Monday;

        public static bool IsTuesday(this DateTimeOffset self) => self.DayOfWeek == DayOfWeek.Tuesday;

        public static bool IsWednesday(this DateTimeOffset self) => self.DayOfWeek == DayOfWeek.Wednesday;

        public static bool IsThursday(this DateTimeOffset self) => self.DayOfWeek == DayOfWeek.Thursday;

        public static bool IsFriday(this DateTimeOffset self) => self.DayOfWeek == DayOfWeek.Friday;

        public static bool IsSaturday(this DateTimeOffset self) => self.DayOfWeek == DayOfWeek.Saturday;

        public static bool IsSunday(this DateTimeOffset self) => self.DayOfWeek == DayOfWeek.Sunday;

        public static bool IsWeekEnds(this DateTimeOffset self) => self.IsSaturday() || self.IsSunday();
    }
}