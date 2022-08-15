using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITFCodeWA.Extensions.DateTimeOffsetExtendors.Tests.Data
{
    internal static partial class TestData
    {
        public static IEnumerable<object[]> GetDayOfWeekLastInMonthValues() => GetRange()
            .Select(i => new object[] { GetRandomDate() })
            .ToList();
    }
}
