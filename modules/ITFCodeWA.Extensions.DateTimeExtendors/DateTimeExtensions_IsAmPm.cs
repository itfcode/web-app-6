namespace ITFCodeWA.Extensions.DateTimeExtendors
{
    using System;

    public static partial class DateTimeExtensions
    {
        public static bool IsAM(this DateTime self) => self.TotalMinutes() < (12 * 60);

        public static bool IsPM(this DateTime self) => !self.IsAM();
    }
}
