using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITFCodeWA.Extensions.DateTimeExtendors.Tests
{
    internal static partial class DateTimeTestData
    {
        public static DateTime TestedDate = DateTime.Now.AddDays(GetRandomValue());

        public static IEnumerable<object[]> GetDayStartValues()
            => GetRange().Select(i => new object[]
            {
                TestedDate.AddDays(i).Date,
                TestedDate.AddDays(i)
            })
            .ToList();

        public static IEnumerable<object[]> GetDayStartAtValues()
            => GetRange().Select(i => new object[]
            {
                TestedDate.AddDays(i).Date,
                TestedDate,
                i
            })
            .ToList();

        public static IEnumerable<object[]> GetDayStartNextValues()
            => GetRange()
            .Select(i => new object[]
            {
                TestedDate.AddDays(i + 1).Date,
                TestedDate.AddDays(i)
            })
            .ToList();

        public static IEnumerable<object[]> GetDayStartPrevValues()
            => GetRange().Select(i => new object[]
            {
                TestedDate.AddDays(i - 1).Date,
                TestedDate.AddDays(i)
            })
            .ToList();

        public static IEnumerable<object[]> GetDayEndValues()
            => GetRange().Select(i => new object[]
            {
                TestedDate.AddDays(i).Date.AddDays(1).AddTicks(-1),
                TestedDate.AddDays(i)
            })
            .ToList();

        public static IEnumerable<object[]> GetDayEndAtValues()
            => GetRange().Select(i => new object[]
            {
                TestedDate.Date.AddDays(i + 1).AddTicks(-1),
                TestedDate,
                i
            })
            .ToList();

        public static IEnumerable<object[]> GetDayEndNextValues()
            => GetRange().Select(i => new object[]
            {
                TestedDate.AddDays(i + 1).Date.AddDays(1).AddTicks(-1),
                TestedDate.AddDays(i)
            })
            .ToList();

        public static IEnumerable<object[]> GetDayEndPrevValues()
            => GetRange().Select(i => new object[]
            {
                TestedDate.AddDays(i - 1).Date.AddDays(1).AddTicks(-1),
                TestedDate.AddDays(i)
            })
            .ToList();
    }
}