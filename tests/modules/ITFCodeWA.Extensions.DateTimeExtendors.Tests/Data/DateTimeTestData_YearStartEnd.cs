using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITFCodeWA.Extensions.DateTimeExtendors.Tests
{
    internal static partial class DateTimeTestData
    {
        public static DateTime YearStart = new DateTime(TestedDate.Year, 1, 1);
        public static DateTime YearEnd = GetYearEnd(0);

        public static IEnumerable<object[]> GetYearStartValues()
            => GetRange().Select(i => new object[]
            {
                YearStart.AddYears(i).Date,
                TestedDate.AddYears(i)
            })
            .ToList();

        public static IEnumerable<object[]> GetYearStartAtValues()
            => GetRange().Select(i => new object[]
            {
                YearStart.AddYears(i).Date,
                TestedDate,
                i
            })
            .ToList();

        public static IEnumerable<object[]> GetYearStartNextValues()
            => GetRange().Select(i => new object[]
            {
                YearStart.AddYears(i + 1).Date,
                TestedDate.AddYears(i)
            })
            .ToList();

        public static IEnumerable<object[]> GetYearStartPrevValues()
            => GetRange().Select(i => new object[]
            {
                YearStart.AddYears(i - 1).Date,
                TestedDate.AddYears(i)
            })
            .ToList();

        public static IEnumerable<object[]> GetYearEndValues()
            => GetRange().Select(i => new object[]
            {
                GetYearEnd(i),
                TestedDate.AddYears(i)
            })
            .ToList();

        public static IEnumerable<object[]> GetYearEndAtValues()
            => GetRange().Select(i => new object[]
            {
                GetYearEnd(i),
                TestedDate,
                i
            })
            .ToList();

        public static IEnumerable<object[]> GetYearEndNextValues()
            => GetRange().Select(i => new object[]
            {
                GetYearEnd(i + 1),
                TestedDate.AddYears(i)
            })
            .ToList();

        public static IEnumerable<object[]> GetYearEndPrevValues()
            => GetRange().Select(i => new object[]
            {
                GetYearEnd(i - 1),
                TestedDate.AddYears(i)
            })
            .ToList();

        public static DateTime GetYearEnd(int year = 0) => YearStart.AddYears(year + 1).AddTicks(-1);

    }
}