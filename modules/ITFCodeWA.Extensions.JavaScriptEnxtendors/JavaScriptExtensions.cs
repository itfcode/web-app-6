namespace ITFCodeWA.Extensions.JavaScriptEnxtendors
{
    using System;

    public static class JavaScriptExtensions
    {
        public static readonly DateTime DateStart = GetJsDateStart();

        public static readonly DateTime DateStartUtc = GetJsDateStart(DateTimeKind.Utc);

        public static readonly long DateStartTicks = GetJsDateStart().Ticks;

        public static readonly long DateStartTicksUtc = GetJsDateStart(DateTimeKind.Utc).Ticks;

        public static long ToJsMilliseconds(this DateTime date) 
            => (date.Ticks - DateStartTicks) / 10000;

        public static long ToJsMillisecondsUtc(this DateTime date)
            => (date.ToUniversalTime().Ticks - DateStartTicksUtc) / 10000;

        public static long ToJsMillisecondsUtc(this DateTimeOffset date)
            => (date.ToUniversalTime().Ticks - DateStartTicksUtc) / 10000;

        public static DateTime FromJsMilliseconds(this long milliseconds)
            => DateStart.AddMilliseconds(milliseconds);

        private static DateTime GetJsDateStart(DateTimeKind kind = DateTimeKind.Local)
            => new DateTime(1970, 1, 1, 0, 0, 0, kind);
    }
}