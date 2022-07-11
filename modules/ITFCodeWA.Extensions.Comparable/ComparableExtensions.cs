namespace ITFCodeWA.Core.Extensions.ComparableExtendors
{
    public static class ComparableExtensions
    {
        public static bool Within<T>(this T self, T start, T finish) where T : IComparable, IComparable<T>
            => self != null ? Predicate(self).Invoke((start, finish)) : throw new ArgumentNullException(nameof(self));

        public static bool WithinAny<T>(this T self, params (T, T)[] values) where T : IComparable, IComparable<T>
            => self != null ? values.Any(Predicate(self)) : throw new ArgumentNullException(nameof(self));

        public static bool WithinAll<T>(this T self, params (T, T)[] values) where T : IComparable, IComparable<T>
            => self != null ? values.All(Predicate(self)) : throw new ArgumentNullException(nameof(self));

        public static bool Without<T>(this T self, T start, T finish) where T : IComparable, IComparable<T>
            => !self.Within(start, finish);

        public static bool WithoutAny<T>(this T self, params (T, T)[] values) where T : IComparable, IComparable<T>
            => !self.WithinAny(values);

        public static bool WithoutAll<T>(this T self, params (T, T)[] values) where T : IComparable, IComparable<T>
            => !self.WithoutAll(values);

        private static Func<(T, T), bool> Predicate<T>(T value) where T : IComparable, IComparable<T>
            => (x) => value.CompareTo(x.Item1) >= 0 && value.CompareTo(x.Item2) <= 0;
    }
}