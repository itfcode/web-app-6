namespace ITFCodeWA.Extensions.DateTimeNullableExtendors.Tests.Data
{
    internal static partial class DateTimeNullableTestData
    {
        public static IEnumerable<object[]> GetDayStartAtValues()
            => GetRange().Select(i => (GetRandomDate(), GetRandomDays()))
            .Select(d => new object[] { d.Item1.Date.AddDays(d.Item2), d.Item1, d.Item2 })
            .ToList();

        public static IEnumerable<object[]> GetDayStartValues()
            => GetRange().Select(i => GetRandomDate())
            .Select(d => new object[] { d.Date, d })
            .ToList();

        public static IEnumerable<object[]> GetDayStartNextValues()
            => GetRange().Select(i => GetRandomDate())
            .Select(d => new object[] { d.Date.AddDays(1), d })
            .ToList();

        public static IEnumerable<object[]> GetDayStartPrevValues()
            => GetRange().Select(i => GetRandomDate())
            .Select(d => new object[] { d.Date.AddDays(-1), d })
            .ToList();

        public static IEnumerable<object[]> GetDayEndAtValues()
             => GetRange().Select(i => (GetRandomDate(), GetRandomDays()))
             .Select(d => new object[] { d.Item1.Date.AddDays(d.Item2 + 1).AddTicks(-1), d.Item1, d.Item2 })
             .ToList();

        public static IEnumerable<object[]> GetDayEndValues()
            => GetRange().Select(i => GetRandomDate())
            .Select(d => new object[] { d.Date.AddDays(1).AddTicks(-1), d })
            .ToList();

        public static IEnumerable<object[]> GetDayEndNextValues()
            => GetRange().Select(i => GetRandomDate())
            .Select(d => new object[] { d.Date.AddDays(2).AddTicks(-1), d })
            .ToList();

        public static IEnumerable<object[]> GetDayEndPrevValues()
            => GetRange().Select(i => GetRandomDate())
            .Select(d => new object[] { d.Date.AddTicks(-1), d })
            .ToList();
    }
}