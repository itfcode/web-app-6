namespace ITFCodeWA.Extensions.DateTimeExtendors
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static partial class DateTimeExtensions
    {
        public static bool IsHoliday(this DateTime self, IEnumerable<DateTime> holidays)
            => holidays != null && holidays.Any(x => x == self);

        public static DateTime CopyTime(this DateTime self, DateTime source)
            => new(self.Year, self.Month, self.Day, source.Hour, source.Minute, source.Second);

        public static DateTime ResetMilliseconds(this DateTime self)
            => new(self.Year, self.Month, self.Day, self.Hour, self.Minute, self.Second, 0);

        public static DateTime ResetSeconds(this DateTime self)
            => new(self.Year, self.Month, self.Day, self.Hour, self.Minute, 0);

        public static DateTime ResetMinutes(this DateTime self)
            => new(self.Year, self.Month, self.Day, self.Hour, 0, 0);
    }
}
