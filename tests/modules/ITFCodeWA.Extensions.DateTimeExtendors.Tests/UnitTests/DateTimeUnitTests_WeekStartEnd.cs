using System;
using System.Collections.Generic;
using Xunit;

namespace ITFCodeWA.Extensions.DateTimeExtendors.Tests.UnitTests
{
    public partial class DateTimeUnitTests
    {
        public static IEnumerable<object[]> WeekStartValues => DateTimeTestData.GetWeekStartValues();
        public static IEnumerable<object[]> WeekStartAtValues => DateTimeTestData.GetWeekStartAtValues();
        public static IEnumerable<object[]> WeekStartNextValues => DateTimeTestData.GetWeekStartNextValues();
        public static IEnumerable<object[]> WeekStartPrevValues => DateTimeTestData.GetWeekStartPrevValues();

        public static IEnumerable<object[]> WeekEndValues => DateTimeTestData.GetWeekEndValues();
        public static IEnumerable<object[]> WeekEndAtValues => DateTimeTestData.GetWeekEndAtValues();
        public static IEnumerable<object[]> WeekEndNextValues => DateTimeTestData.GetWeekEndNextValues();
        public static IEnumerable<object[]> WeekEndPrevValues => DateTimeTestData.GetWeekEndPrevValues();

        [Fact]
        public void WeekStartEndData_Tests() 
        {
            var weekStart = DateTimeTestData.WeekStartDate;
            var weekEnd = DateTimeTestData.WeekEndDate;

            Assert.Equal(weekStart.Date, weekStart);
            Assert.Equal(weekEnd.AddTicks(1).Date, weekEnd.AddTicks(1));

            Assert.Equal(DayOfWeek.Monday, weekStart.DayOfWeek);
            Assert.Equal(DayOfWeek.Sunday, weekEnd.DayOfWeek);
        }

        [Theory]
        [MemberData(nameof(WeekStartValues))]
        public void WeekStart_Test(DateTime expected, DateTime source)
        {
            Assert.Equal(expected, source.WeekStart());
        }

        [Theory]
        [MemberData(nameof(WeekStartAtValues))]
        public void WeekStartAt_Test(DateTime expected, DateTime source, int value)
        {
            Assert.Equal(expected, source.WeekStartAt(value));
        }

        [Theory]
        [MemberData(nameof(WeekStartNextValues))]
        public void WeekStartNext_Test(DateTime expected, DateTime source)
        {
            Assert.Equal(expected, source.WeekStartNext());
        }

        [Theory]
        [MemberData(nameof(WeekStartPrevValues))]
        public void WeekStartPrev_Test(DateTime expected, DateTime source)
        {
            Assert.Equal(expected, source.WeekStartPrev());
        }

        [Theory]
        [MemberData(nameof(WeekEndValues))]
        public void WeekEnd_Test(DateTime expected, DateTime source)
        {
            Assert.Equal(expected, source.WeekEnd());
        }

        [Theory]
        [MemberData(nameof(WeekEndAtValues))]
        public void WeekEndAt_Test(DateTime expected, DateTime source, int value)
        {
            Assert.Equal(expected, source.WeekEndAt(value));
        }

        [Theory]
        [MemberData(nameof(WeekEndNextValues))]
        public void WeekEndNext_Test(DateTime expected, DateTime source)
        {
            Assert.Equal(expected, source.WeekEndNext());
        }

        [Theory]
        [MemberData(nameof(WeekEndPrevValues))]
        public void WeekEndPrev_Test(DateTime expected, DateTime source)
        {
            Assert.Equal(expected, source.WeekEndPrev());
        }
    }
}