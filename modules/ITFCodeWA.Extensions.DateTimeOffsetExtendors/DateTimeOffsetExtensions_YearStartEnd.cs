namespace ITFCodeWA.Extensions.DateTimeOffsetExtendors
{
    public static partial class DateTimeOffsetExtensions
    {
        public static DateTimeOffset YearStartAt(this DateTimeOffset self, int years = 0) => GetYearStart(self).AddYears(years);
        public static DateTimeOffset YearStart(this DateTimeOffset self) => self.YearStartAt(0);
        public static DateTimeOffset YearStartPrev(this DateTimeOffset self) => self.YearStartAt(-1);
        public static DateTimeOffset YearStartNext(this DateTimeOffset self) => self.YearStartAt(1);

        public static DateTimeOffset YearEndAt(this DateTimeOffset self, int years = 0) => self.YearStartAt(years + 1).AddTicks(-1);
        public static DateTimeOffset YearEnd(this DateTimeOffset self) => self.YearEndAt(0);
        public static DateTimeOffset YearEndPrev(this DateTimeOffset self) => self.YearEndAt(-1);
        public static DateTimeOffset YearEndNext(this DateTimeOffset self) => self.YearEndAt(1);

        private static DateTimeOffset GetYearStart(DateTimeOffset date) => new DateTimeOffset(new DateTime(date.Year, 1, 1), date.Offset);
    }
}