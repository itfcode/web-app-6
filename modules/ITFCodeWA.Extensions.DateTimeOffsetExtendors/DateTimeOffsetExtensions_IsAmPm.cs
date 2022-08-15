namespace ITFCodeWA.Extensions.DateTimeOffsetExtendors
{
    public static partial class DateTimeOffsetExtensions
    {
        public static bool IsAm(this DateTimeOffset self)
            => self.Hour < 12;

        public static bool IsPm(this DateTimeOffset self)
            => self.Hour >= 12;
    }
}