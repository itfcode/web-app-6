namespace ITFCodeWA.Extensions.DateTimeNullableExtendors.Tests.Data
{
    internal static partial class DateTimeNullableTestData
    {
        public static IEnumerable<object[]> GetAddValues()
            => GetRange().Select(i => new object[]
            {
                GetRandomDate(),
                new TimeSpan(GetRandomTicks())
            })
            .Union(new List<object[]> { new object[] { GetRandomDate(), new TimeSpan(0) } })
            .ToList();

        public static IEnumerable<object[]> GetAddTicksValues()
            => GetRange().Select(i => new object[]
            {
                GetRandomDate(),
                GetRandomTicks()
            })
            .Union(new List<object[]> { new object[] { GetRandomDate(), 0 } })
            .ToList();

        public static IEnumerable<object[]> GetAddMillisecondsValues()
            => GetRange().Select(i => new object[]
            {
                GetRandomDate(),
                GetRandomMilliseconds()
            })
            .Union(new List<object[]> { new object[] { GetRandomDate(), 0 } })
            .ToList();

        public static IEnumerable<object[]> GetAddSecondsValues()
            => GetRange().Select(i => new object[]
            {
                GetRandomDate(),
                GetRandomSeconds()
            })
            .Union(new List<object[]> { new object[] { GetRandomDate(), 0 } })
            .ToList();

        public static IEnumerable<object[]> GetAddMinutesValues()
            => GetRange().Select(i => new object[]
            {
                GetRandomDate(),
                GetRandomMinutes()
            })
            .Union(new List<object[]> { new object[] { GetRandomDate(), 0 } })
            .ToList();

        public static IEnumerable<object[]> GetAddHoursValues()
            => GetRange().Select(i => new object[]
            {
                GetRandomDate(),
                GetRandomHour()
            })
            .Union(new List<object[]> { new object[] { GetRandomDate(), 0 } })
            .ToList();

        public static IEnumerable<object[]> GetAddDaysValues()
            => GetRange().Select(i => new object[]
            {
                GetRandomDate(),
                GetRandomDays()
            })
            .Union(new List<object[]> { new object[] { GetRandomDate(), 0 } })
            .ToList();

        public static IEnumerable<object[]> GetAddMonthsValues()
            => GetRange().Select(i => new object[]
            {
                GetRandomDate(),
                GetRandomMonth()
            })
            .Union(new List<object[]> { new object[] { GetRandomDate(), 0 } })
            .ToList();

        public static IEnumerable<object[]> GetAddYearsValues()
            => GetRange().Select(i => new object[]
            {
                GetRandomDate(),
                GetRandomMonth()
            })
            .Union(new List<object[]> { new object[] { GetRandomDate(), 0 } })
            .ToList();
    }
}
