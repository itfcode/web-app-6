using System;
using System.Collections.Generic;
using System.Linq;

namespace ITFCodeWA.Extensions.DateTimeExtendors.Tests
{
    internal static partial class DateTimeTestData
    {
        public static readonly DateTime QuarterStart = new DateTime(TestedDate.Year, (GetQuarterNumber(TestedDate.Month) - 1) * 3 + 1, 1);
        public static readonly DateTime QuarterEnd = GetQuarterEnd();

        public static IEnumerable<object[]> GetQuarterStartValues()
            => GetRange().Select(i => new object[]
            {
                QuarterStart.AddMonths(3 * i).Date,
                TestedDate.AddMonths(3 * i)
            })
            .ToList();

        public static IEnumerable<object[]> GetQuarterStartAtValues()
            => GetRange().Select(i => new object[]
            {
                QuarterStart.AddMonths(3 * i).Date,
                TestedDate,
                i
            })
            .ToList();

        public static IEnumerable<object[]> GetQuarterStartNextValues()
            => GetRange().Select(i => new object[]
            {
                QuarterStart.AddMonths(3 * i + 3).Date,
                TestedDate.AddMonths(3 * i)
            })
            .ToList();

        public static IEnumerable<object[]> GetQuarterStartPrevValues()
            => GetRange().Select(i => new object[]
            {
                QuarterStart.AddMonths(3 * i - 3).Date,
                TestedDate.AddMonths(3 * i)
            })
            .ToList();

        public static IEnumerable<object[]> GetQuarterEndValues()
            => GetRange().Select(i => new object[]
            {
                GetQuarterEnd(i),
                TestedDate.AddMonths(3 * i)
            })
            .ToList();

        public static IEnumerable<object[]> GetQuarterEndAtValues()
            => GetRange().Select(i => new object[]
            {
                GetQuarterEnd(i),
                TestedDate,
                i
            })
            .ToList();

        public static IEnumerable<object[]> GetQuarterEndNextValues()
            => GetRange().Select(i => new object[]
            {
                GetQuarterEnd(i + 1),
                TestedDate.AddMonths(3 * i)
            })
            .ToList();

        public static IEnumerable<object[]> GetQuarterEndPrevValues()
            => GetRange().Select(i => new object[]
            {
                GetQuarterEnd(i - 1),
                TestedDate.AddMonths(3 * i)
            })
            .ToList();

        public static int GetQuarterNumber(int month) => month switch
        {
            1 or 2 or 3 => 1,
            4 or 5 or 6 => 2,
            7 or 8 or 9 => 3,
            10 or 11 or 12 => 4,
            _ => throw new ArgumentOutOfRangeException(nameof(month))
        };

        public static DateTime GetQuarterEnd(int quarter = 0) => QuarterStart.AddMonths(3 * quarter + 3).AddTicks(-1);
    }
}