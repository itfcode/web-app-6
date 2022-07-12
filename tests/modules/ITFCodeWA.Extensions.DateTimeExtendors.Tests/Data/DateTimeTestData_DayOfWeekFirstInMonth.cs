using System.Collections.Generic;
using System.Linq;

namespace ITFCodeWA.Extensions.DateTimeExtendors.Tests
{
    internal static partial class DateTimeTestData
    {
        public static IEnumerable<object[]> GetDayOfWeekFirstInMonthValues() => GetRange()
            .Select(i => new object[] { TestedDate.AddDays(5 * GetRandomValue()) })
            .ToList();
    }
}