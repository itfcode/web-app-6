namespace ITFCodeWA.Extensions.DateTimeOffsetExtendors.Tests.Data
{
    internal static partial class TestData
    {
        private static readonly int _valueCount = 50;

        private static readonly int _startRange = -5;

        private static IEnumerable<int> GetRange() => Enumerable.Range(_startRange, _valueCount);

        private static int GetRandomValue(int min = -100, int max = 100) => new Random().Next(min, max);

        private static int GetRandomTicks() => GetRandomValue(-1000 * 5000, 1000 * 5000);
        private static int GetRandomMilliseconds() => GetRandomValue(-100 * 5000, 100 * 5000);
        private static int GetRandomSeconds() => GetRandomValue(-5000, 5000);
        private static int GetRandomMinutes() => GetRandomValue(-5000, 5000);
        private static int GetRandomHour() => GetRandomValue(-1000, 1000);
        private static int GetRandomDays() => GetRandomValue(-1000, 1000);
        private static int GetRandomMonth() => GetRandomValue(-100, 100);
        private static int GetRandomYear() => GetRandomValue(-100, 100);

        private static DateTime GetRandomDate() => DateTime.Now.AddMinutes(GetRandomValue(-5000, 5000));
    }
}
