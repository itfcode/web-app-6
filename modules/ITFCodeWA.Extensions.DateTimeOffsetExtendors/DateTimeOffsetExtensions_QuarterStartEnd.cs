namespace ITFCodeWA.Extensions.DateTimeOffsetExtendors
{
    public static partial class DateTimeOffsetExtensions
    {
        public static DateTimeOffset QuarterStartAt(this DateTimeOffset self, int quarters) => GetQuarterStart(self).AddMonths(quarters * 3);
        public static DateTimeOffset QuarterStart(this DateTimeOffset self) => self.QuarterStartAt(0);
        public static DateTimeOffset QuarterStartPrev(this DateTimeOffset self) => self.QuarterStartAt(-1);
        public static DateTimeOffset QuarterStartNext(this DateTimeOffset self) => self.QuarterStartAt(1);

        public static DateTimeOffset QuarterEndAt(this DateTimeOffset self, int quarters) => self.QuarterStartAt(quarters + 1).AddTicks(-1);
        public static DateTimeOffset QuarterEnd(this DateTimeOffset self) => self.QuarterEndAt(0);
        public static DateTimeOffset QuarterEndPrev(this DateTimeOffset self) => self.QuarterEndAt(-1);
        public static DateTimeOffset QuarterEndNext(this DateTimeOffset self) => self.QuarterEndAt(1);

        private static DateTimeOffset GetQuarterStart(DateTimeOffset date) 
        {
            var quarterNumber = date.Month switch
            {
                1 or 2 or 3 => 0,
                4 or 5 or 6 => 1,
                7 or 8 or 9 => 2,
                10 or 11 or 12 => 3,
                _ => throw new NotSupportedException($"Number of month is greater then 12"),
            };

            return new DateTimeOffset(date.Year, quarterNumber * 3 + 1, 1, 0, 0, 0, date.Offset);
        } 
    }
}