using System;
using System.Collections.Generic;
using System.Linq;

namespace ITFCodeWA.Extensions.DateTimeExtendors.Tests
{
    internal static partial class DateTimeTestData
    {
        private static DateTime GetMonthEnd(int month = 0) => MonthStart.AddMonths(month + 1).AddTicks(-1);

        public static readonly DateTime MonthStart = new DateTime(TestedDate.Year, TestedDate.Month, 1);
        public static readonly DateTime MonthEnd = GetMonthEnd();

        public static IEnumerable<object[]> GetMonthStartValues()
            => GetRange().Select(i => new object[]
            {
                MonthStart.AddMonths(i).Date,
                TestedDate.AddMonths(i)
            })
            .ToList();

        public static IEnumerable<object[]> GetMonthStartAtValues()
            => GetRange().Select(i => new object[]
            {
                MonthStart.AddMonths(i).Date,
                TestedDate,
                i
            })
            .ToList();

        public static IEnumerable<object[]> GetMonthStartNextValues()
            => GetRange().Select(i => new object[]
            {
                MonthStart.AddMonths(i + 1).Date,
                TestedDate.AddMonths(i)
            })
            .ToList();

        public static IEnumerable<object[]> GetMonthStartPrevValues()
            => GetRange().Select(i => new object[]
            {
                MonthStart.AddMonths(i - 1).Date,
                TestedDate.AddMonths(i)
            })
            .ToList();

        public static IEnumerable<object[]> GetMonthEndValues()
            => GetRange().Select(i => new object[]
            {
                GetMonthEnd(i),
                TestedDate.AddMonths(i)
            })
            .ToList();

        public static IEnumerable<object[]> GetMonthEndAtValues()
            => GetRange().Select(i => new object[]
            {
                GetMonthEnd(i),
                TestedDate,
                i
            })
            .ToList();

        public static IEnumerable<object[]> GetMonthEndNextValues()
            => GetRange().Select(i => new object[]
            {
                GetMonthEnd(i + 1),
                TestedDate.AddMonths(i)
            })
            .ToList();

        public static IEnumerable<object[]> GetMonthEndPrevValues()
            => GetRange().Select(i => new object[]
            {
                GetMonthEnd(i - 1),
                TestedDate.AddMonths(i)
            })
            .ToList();
    }
}