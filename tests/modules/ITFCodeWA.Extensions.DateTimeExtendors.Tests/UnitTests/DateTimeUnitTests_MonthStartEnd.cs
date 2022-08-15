using System;
using System.Collections.Generic;
using Xunit;

namespace ITFCodeWA.Extensions.DateTimeExtendors.Tests.UnitTests
{
    public partial class DateTimeUnitTests
    {
        public static IEnumerable<object[]> MonthStartValues => DateTimeTestData.GetMonthStartValues();
        public static IEnumerable<object[]> MonthStartAtValues => DateTimeTestData.GetMonthStartAtValues();
        public static IEnumerable<object[]> MonthStartNextValues => DateTimeTestData.GetMonthStartNextValues();
        public static IEnumerable<object[]> MonthStartPrevValues => DateTimeTestData.GetMonthStartPrevValues();

        public static IEnumerable<object[]> MonthEndValues => DateTimeTestData.GetMonthEndValues();
        public static IEnumerable<object[]> MonthEndAtValues => DateTimeTestData.GetMonthEndAtValues();
        public static IEnumerable<object[]> MonthEndNextValues => DateTimeTestData.GetMonthEndNextValues();
        public static IEnumerable<object[]> MonthEndPrevValues => DateTimeTestData.GetMonthEndPrevValues();

        [Fact]
        public void MonthStartDate_Test()
        {
            var monthStart = DateTimeTestData.MonthStart;
            Assert.Equal(monthStart, monthStart.Date);
            Assert.Equal(1, monthStart.Day);
            Assert.Equal(0, monthStart.Hour);
            Assert.Equal(0, monthStart.Minute);
            Assert.Equal(0, monthStart.Second);
            Assert.Equal(0, monthStart.Millisecond);
        }

        [Fact]
        public void MonthEndDate_Test()
        {
            var monthStart = DateTimeTestData.MonthStart;
            var monthEnd = DateTimeTestData.MonthEnd;
            Assert.Equal(monthEnd.AddTicks(1), monthEnd.AddTicks(1).Date);
            Assert.Equal(monthEnd.AddTicks(1), monthStart.AddMonths(1));
        }

        [Theory]
        [MemberData(nameof(MonthStartValues))]
        public void MonthStart_Test(DateTime expected, DateTime source)
        {
            Assert.Equal(expected, source.MonthStart());
        }

        [Theory]
        [MemberData(nameof(MonthStartAtValues))]
        public void MonthStartAt_Test(DateTime expected, DateTime source, int value)
        {
            Assert.Equal(expected, source.MonthStartAt(value));
        }

        [Theory]
        [MemberData(nameof(MonthStartNextValues))]
        public void MonthStartNext_Test(DateTime expected, DateTime source)
        {
            Assert.Equal(expected, source.MonthStartNext());
        }

        [Theory]
        [MemberData(nameof(MonthStartPrevValues))]
        public void MonthStartPrev_Test(DateTime expected, DateTime source)
        {
            Assert.Equal(expected, source.MonthStartPrev());
        }

        [Theory]
        [MemberData(nameof(MonthEndValues))]
        public void MonthEnd_Test(DateTime expected, DateTime source)
        {
            Assert.Equal(expected, source.MonthEnd());
        }

        [Theory]
        [MemberData(nameof(MonthEndAtValues))]
        public void MonthEndAt_Test(DateTime expected, DateTime source, int value)
        {
            Assert.Equal(expected, source.MonthEndAt(value));
        }

        [Theory]
        [MemberData(nameof(MonthEndNextValues))]
        public void MonthEndNext_Test(DateTime expected, DateTime source)
        {
            Assert.Equal(expected, source.MonthEndNext());
        }

        [Theory]
        [MemberData(nameof(MonthEndPrevValues))]
        public void MonthEndPrev_Test(DateTime expected, DateTime source)
        {
            Assert.Equal(expected, source.MonthEndPrev());
        }
    }
}