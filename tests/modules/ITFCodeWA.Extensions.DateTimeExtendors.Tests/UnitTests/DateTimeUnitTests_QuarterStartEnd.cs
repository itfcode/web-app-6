using System;
using System.Collections.Generic;
using Xunit;

namespace ITFCodeWA.Extensions.DateTimeExtendors.Tests.UnitTests
{
    public partial class DateTimeUnitTests
    {
        public static IEnumerable<object[]> QuarterStartValues => DateTimeTestData.GetQuarterStartValues();
        public static IEnumerable<object[]> QuarterStartAtValues => DateTimeTestData.GetQuarterStartAtValues();
        public static IEnumerable<object[]> QuarterStartNextValues => DateTimeTestData.GetQuarterStartNextValues();
        public static IEnumerable<object[]> QuarterStartPrevValues => DateTimeTestData.GetQuarterStartPrevValues();

        public static IEnumerable<object[]> QuarterEndValues => DateTimeTestData.GetQuarterEndValues();
        public static IEnumerable<object[]> QuarterEndAtValues => DateTimeTestData.GetQuarterEndAtValues();
        public static IEnumerable<object[]> QuarterEndNextValues => DateTimeTestData.GetQuarterEndNextValues();
        public static IEnumerable<object[]> QuarterEndPrevValues => DateTimeTestData.GetQuarterEndPrevValues();

        [Theory]
        [MemberData(nameof(QuarterStartValues))]
        public void QuarterStart_Test(DateTime expected, DateTime source)
        {
            Assert.Equal(expected, source.QuarterStart());
        }

        [Theory]
        [MemberData(nameof(QuarterStartAtValues))]
        public void QuarterStartAt_Test(DateTime expected, DateTime source, int value)
        {
            Assert.Equal(expected, source.QuarterStartAt(value));
        }

        [Theory]
        [MemberData(nameof(QuarterStartNextValues))]
        public void QuarterStartNext_Test(DateTime expected, DateTime source)
        {
            Assert.Equal(expected, source.QuarterStartNext());
        }

        [Theory]
        [MemberData(nameof(QuarterStartPrevValues))]
        public void QuarterStartPrev_Test(DateTime expected, DateTime source)
        {
            Assert.Equal(expected, source.QuarterStartPrev());
        }

        [Theory]
        [MemberData(nameof(QuarterEndValues))]
        public void QuarterEnd_Test(DateTime expected, DateTime source)
        {
            Assert.Equal(expected, source.QuarterEnd());
        }

        [Theory]
        [MemberData(nameof(QuarterEndAtValues))]
        public void QuarterEndAt_Test(DateTime expected, DateTime source, int value)
        {
            Assert.Equal(expected, source.QuarterEndAt(value));
        }

        [Theory]
        [MemberData(nameof(QuarterEndNextValues))]
        public void QuarterEndNext_Test(DateTime expected, DateTime source)
        {
            Assert.Equal(expected, source.QuarterEndNext());
        }

        [Theory]
        [MemberData(nameof(QuarterEndPrevValues))]
        public void QuarterEndPrev_Test(DateTime expected, DateTime source)
        {
            Assert.Equal(expected, source.QuarterEndPrev());
        }
    }
}
