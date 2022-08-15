using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITFCodeWA.Extensions.DateTimeExtendors.Tests
{
    internal static partial class DateTimeTestData
    {
        public static readonly DateTime WeekStartDate = GetWeekStart();
        public static readonly DateTime WeekEndDate = GetWeekEnd(0);

        public static IEnumerable<object[]> GetWeekStartValues()
            => GetRange().Select(i => new object[]
            {
                WeekStartDate.AddDays(7 * i).Date,
                WeekStartDate.AddDays(7 * i)
            })
            .ToList();

        public static IEnumerable<object[]> GetWeekStartAtValues()
            => GetRange().Select(i => new object[]
            {
                WeekStartDate.AddDays(7 * i).Date,
                WeekStartDate,
                i
            })
            .ToList();

        public static IEnumerable<object[]> GetWeekStartNextValues()
            => GetRange().Select(i => new object[]
            {
                WeekStartDate.AddDays(7 * i + 7).Date,
                WeekStartDate.AddDays(7 * i)
            })
            .ToList();

        public static IEnumerable<object[]> GetWeekStartPrevValues()
            => GetRange().Select(i => new object[]
            {
                WeekStartDate.AddDays(7 * i - 7).Date,
                WeekStartDate.AddDays(7 * i)
            })
            .ToList();

        public static IEnumerable<object[]> GetWeekEndValues()
            => GetRange().Select(i => new object[]
            {
                GetWeekEnd(i),
                TestedDate.AddDays(i * 7)
            })
            .ToList();

        public static IEnumerable<object[]> GetWeekEndAtValues()
            => GetRange().Select(i => new object[]
            {
                GetWeekEnd(i),
                TestedDate,
                i
            })
            .ToList();

        public static IEnumerable<object[]> GetWeekEndNextValues()
            => GetRange()
            .Select(i => new object[]
            {
                GetWeekEnd(i + 1),
                TestedDate.AddDays(i * 7)
            })
            .ToList();

        public static IEnumerable<object[]> GetWeekEndPrevValues()
            => GetRange()
            .Select(i => new object[]
            {
                GetWeekEnd(i - 1),
                TestedDate.AddDays(i * 7)
            })
            .ToList();

        public static DateTime GetWeekStart(int weeks = 0)
        {
            var date = TestedDate.Date;
            var dayMinus = date.DayOfWeek switch
            {
                DayOfWeek.Monday => 0,
                DayOfWeek.Tuesday => -1,
                DayOfWeek.Wednesday => -2,
                DayOfWeek.Thursday => -3,
                DayOfWeek.Friday => -4,
                DayOfWeek.Saturday => -5,
                DayOfWeek.Sunday => -6,
                _ => throw new ArgumentOutOfRangeException()
            };

            return date.AddDays(dayMinus).AddDays(weeks * 7);
        }

        public static DateTime GetWeekEnd(int weeks = 0) => WeekStartDate.AddDays(weeks * 7 + 7).AddTicks(-1);
    }
}