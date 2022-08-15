using System;
using System.Collections.Generic;
using Xunit;

namespace ITFCodeWA.Extensions.DateTimeExtendors.Tests.UnitTests
{
    public partial class DateTimeUnitTests
    {
        public static IEnumerable<object[]> DayStartValues => DateTimeTestData.GetDayStartValues();
        public static IEnumerable<object[]> DayStartAtValues => DateTimeTestData.GetDayStartAtValues();
        public static IEnumerable<object[]> DayStartNextValues => DateTimeTestData.GetDayStartNextValues();
        public static IEnumerable<object[]> DayStartPrevValues => DateTimeTestData.GetDayStartPrevValues();

        public static IEnumerable<object[]> DayEndValues => DateTimeTestData.GetDayEndValues();
        public static IEnumerable<object[]> DayEndAtValues => DateTimeTestData.GetDayEndAtValues();
        public static IEnumerable<object[]> DayEndNextValues => DateTimeTestData.GetDayEndNextValues();
        public static IEnumerable<object[]> DayEndPrevValues => DateTimeTestData.GetDayEndPrevValues();

        [Theory]
        [MemberData(nameof(DayStartValues))]
        public void DayStart_Test(DateTime expected, DateTime source)
        {
            Assert.Equal(expected, source.DayStart());
        }

        [Theory]
        [MemberData(nameof(DayStartAtValues))]
        public void DayStartAt_Test(DateTime expected, DateTime source, int value)
        {
            Assert.Equal(expected, source.DayStartAt(value));
        }

        [Theory]
        [MemberData(nameof(DayStartNextValues))]
        public void DayStartNext_Test(DateTime expected, DateTime source)
        {
            Assert.Equal(expected, source.DayStartNext());
        }

        [Theory]
        [MemberData(nameof(DayStartPrevValues))]
        public void DayStartPrev_Test(DateTime expected, DateTime source)
        {
            Assert.Equal(expected, source.DayStartPrev());
        }

        [Theory]
        [MemberData(nameof(DayEndValues))]
        public void DayEnd_Test(DateTime expected, DateTime source)
        {
            Assert.Equal(expected, source.DayEnd());
        }

        [Theory]
        [MemberData(nameof(DayEndAtValues))]
        public void DayEndAt_Test(DateTime expected, DateTime source, int value)
        {
            Assert.Equal(expected, source.DayEndAt(value));
        }

        [Theory]
        [MemberData(nameof(DayEndNextValues))]
        public void DayEndNext_Test(DateTime expected, DateTime source)
        {
            Assert.Equal(expected, source.DayEndNext());
        }

        [Theory]
        [MemberData(nameof(DayEndPrevValues))]
        public void DayEndPrev_Test(DateTime expected, DateTime source)
        {
            Assert.Equal(expected, source.DayEndPrev());
        }
    }
}
