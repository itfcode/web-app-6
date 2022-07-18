namespace ITFCodeWA.Extensions.StringExtendors
{
    public static class StringExtensions
    {
        public static bool EqualsAtIgnoreCase(this string self, string compared)
            => self.Equals(compared, StringComparison.InvariantCultureIgnoreCase);

        public static string FirstCharToUpper(this string self)
            => self switch
            {
                null => throw new ArgumentNullException(nameof(self)),
                "" => throw new ArgumentException($"{nameof(self)} cannot be empty", nameof(self)),
                _ => string.Concat(self[0].ToString().ToUpper(), self.AsSpan(1))
            };

        public static string FirstCharToLower(this string self)
            => self switch
            {
                null => throw new ArgumentNullException(nameof(self)),
                "" => throw new ArgumentException($"{nameof(self)} cannot be empty", nameof(self)),
                _ => string.Concat(self[0].ToString().ToLower(), self.AsSpan(1))
            };
    }
}