namespace ITFCodeWA.Extensions.DateTimeExtendors
{
    using System;

    public static partial class DateTimeExtensions
    {
        public static int TotalMinutes(this DateTime self) => self.Minute + self.Hour * 60;

        public static int TotalSeconds(this DateTime self) => self.TotalMinutes() * 60 + self.Second;

        public static int TotalMilliseconds(this DateTime self) => self.TotalSeconds() * 1000 + self.Millisecond;
    }
}
