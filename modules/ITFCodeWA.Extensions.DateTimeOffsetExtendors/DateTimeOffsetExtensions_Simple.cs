namespace ITFCodeWA.Extensions.DateTimeOffsetExtendors
{
    public static partial class DateTimeOffsetExtensions
    {
        public static DateTimeOffset CopyTime(this DateTimeOffset self, DateTimeOffset source)
            => new(self.Year, self.Month, self.Day, source.Hour, source.Minute, source.Second, source.Millisecond, self.Offset);

        public static DateTimeOffset ResetMilliseconds(this DateTimeOffset self)
            => new(self.Year, self.Month, self.Day, self.Hour, self.Minute, self.Second, 0, self.Offset);

        public static DateTimeOffset ResetSeconds(this DateTimeOffset self)
            => new(self.Year, self.Month, self.Day, self.Hour, self.Minute, 0, 0, self.Offset);

        public static DateTimeOffset ResetMinutes(this DateTimeOffset self)
            => new(self.Year, self.Month, self.Day, self.Hour, 0, 0, 0, self.Offset);
    }
}