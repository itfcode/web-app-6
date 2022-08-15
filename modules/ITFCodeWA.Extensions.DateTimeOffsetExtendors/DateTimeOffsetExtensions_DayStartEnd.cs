namespace ITFCodeWA.Extensions.DateTimeOffsetExtendors
{
    public static partial class DateTimeOffsetExtensions
    {
        public static DateTimeOffset DayStartAt(this DateTimeOffset self, int days = 0) => GetDayStart(self).AddDays(days);
        public static DateTimeOffset DayStart(this DateTimeOffset self) => self.DayStartAt(0);
        public static DateTimeOffset DayStartPrev(this DateTimeOffset self) => self.DayStartAt(-1);
        public static DateTimeOffset DayStartNext(this DateTimeOffset self) => self.DayStartAt(1);

        public static DateTimeOffset DayEndAt(this DateTimeOffset self, int days = 0) => self.DayStartAt(days + 1).AddTicks(-1);
        public static DateTimeOffset DayEnd(this DateTimeOffset self) => self.DayEndAt(0);
        public static DateTimeOffset DayEndPrev(this DateTimeOffset self) => self.DayEndAt(-1);
        public static DateTimeOffset DayEndNext(this DateTimeOffset self) => self.DayEndAt(1);

        private static DateTimeOffset GetDayStart(DateTimeOffset date) => new DateTimeOffset(date.Year, date.Month, 1, 0, 0, 0, date.Offset);
    }
}