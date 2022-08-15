using System;
using System.Collections.Generic;
using Xunit;

namespace ITFCodeWA.Extensions.DateTimeExtendors.Tests.UnitTests
{
    public partial class DateTimeUnitTests
    {
        public static IEnumerable<object[]> YearStartValues => DateTimeTestData.GetYearStartValues();
        public static IEnumerable<object[]> YearStartAtValues => DateTimeTestData.GetYearStartAtValues();
        public static IEnumerable<object[]> YearStartNextValues => DateTimeTestData.GetYearStartNextValues();
        public static IEnumerable<object[]> YearStartPrevValues => DateTimeTestData.GetYearStartPrevValues();

        public static IEnumerable<object[]> YearEndValues => DateTimeTestData.GetYearEndValues();
        public static IEnumerable<object[]> YearEndAtValues => DateTimeTestData.GetYearEndAtValues();
        public static IEnumerable<object[]> YearEndNextValues => DateTimeTestData.GetYearEndNextValues();
        public static IEnumerable<object[]> YearEndPrevValues => DateTimeTestData.GetYearEndPrevValues();

        [Theory]
        [MemberData(nameof(YearStartValues))]
        public void YearStart_Test(DateTime expected, DateTime source)
        {
            Assert.Equal(expected, source.YearStart());
        }

        [Theory]
        [MemberData(nameof(YearStartAtValues))]
        public void YearStartAt_Test(DateTime expected, DateTime source, int value)
        {
            Assert.Equal(expected, source.YearStartAt(value));
        }

        [Theory]
        [MemberData(nameof(YearStartNextValues))]
        public void YearStartNext_Test(DateTime expected, DateTime source)
        {
            Assert.Equal(expected, source.YearStartNext());
        }

        [Theory]
        [MemberData(nameof(YearStartPrevValues))]
        public void YearStartPrev_Test(DateTime expected, DateTime source)
        {
            Assert.Equal(expected, source.YearStartPrev());
        }

        [Theory]
        [MemberData(nameof(YearEndValues))]
        public void YearEnd_Test(DateTime expected, DateTime source)
        {
            Assert.Equal(expected, source.YearEnd());
        }

        [Theory]
        [MemberData(nameof(YearEndAtValues))]
        public void YearEndAt_Test(DateTime expected, DateTime source, int value)
        {
            Assert.Equal(expected, source.YearEndAt(value));
        }

        [Theory]
        [MemberData(nameof(YearEndNextValues))]
        public void YearEndNext_Test(DateTime expected, DateTime source)
        {
            Assert.Equal(expected, source.YearEndNext());
        }

        [Theory]
        [MemberData(nameof(YearEndPrevValues))]
        public void YearEndPrev_Test(DateTime expected, DateTime source)
        {
            Assert.Equal(expected, source.YearEndPrev());
        }
    }
}
