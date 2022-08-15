using ITFCodeWA.Extensions.DateTimeNullableExtendors.Tests.Data;

namespace ITFCodeWA.Extensions.DateTimeNullableExtendors.Tests
{
    public partial class DateTimeNullabeUnitTests
    {
        public static IEnumerable<object[]> DayStartAtValues => DateTimeNullableTestData.GetDayStartAtValues();
        public static IEnumerable<object[]> DayStartValues => DateTimeNullableTestData.GetDayStartValues();
        public static IEnumerable<object[]> DayStartNextValues => DateTimeNullableTestData.GetDayStartNextValues();
        public static IEnumerable<object[]> DayStartPrevValues => DateTimeNullableTestData.GetDayStartPrevValues();

        public static IEnumerable<object[]> DayEndAtValues => DateTimeNullableTestData.GetDayEndAtValues();
        public static IEnumerable<object[]> DayEndValues => DateTimeNullableTestData.GetDayEndValues();
        public static IEnumerable<object[]> DayEndNextValues => DateTimeNullableTestData.GetDayEndNextValues();
        public static IEnumerable<object[]> DayEndPrevValues => DateTimeNullableTestData.GetDayEndPrevValues();

        [Theory]
        [MemberData(nameof(DayStartAtValues))]
        public void DayStartAt_Test(DateTime? expected, DateTime? testedDate, int days)
        {
            Assert.Equal(expected, testedDate.DayStartAt(days));

            Assert.Throws<ArgumentNullException>(() => TestedDateNull.DayStartAt(days));
            Assert.Equal(TestedDateNull, TestedDateNull.DayStartAt(days, false));
        }

        [Theory]
        [MemberData(nameof(DayStartValues))]
        public void DayStart_Test(DateTime expected, DateTime? testedDate)
        {
            Assert.Equal(expected, testedDate.DayStart());

            Assert.Throws<ArgumentNullException>(() => TestedDateNull.DayStart());
            Assert.Equal(TestedDateNull, TestedDateNull.DayStart(false));
        }

        [Theory]
        [MemberData(nameof(DayStartNextValues))]
        public void DayStartNext_Test(DateTime expected, DateTime? testedDate)
        {
            Assert.Equal(expected, testedDate.DayStartNext());

            Assert.Throws<ArgumentNullException>(() => TestedDateNull.DayStartNext());
            Assert.Equal(TestedDateNull, TestedDateNull.DayStartNext(false));
        }

        [Theory]
        [MemberData(nameof(DayStartPrevValues))]
        public void DayStartPrev_Test(DateTime expected, DateTime? testedDate)
        {
            Assert.Equal(expected, testedDate.DayStartPrev());

            Assert.Throws<ArgumentNullException>(() => TestedDateNull.DayStartPrev());
            Assert.Equal(TestedDateNull, TestedDateNull.DayStartPrev(false));
        }

        [Theory]
        [MemberData(nameof(DayEndAtValues))]
        public void DayEndAt_Test(DateTime? expected, DateTime? testedDate, int days)
        {
            Assert.Equal(expected, testedDate.DayEndAt(days));

            Assert.Throws<ArgumentNullException>(() => TestedDateNull.DayEndAt(days));
            Assert.Equal(TestedDateNull, TestedDateNull.DayEndAt(days, false));
        }

        [Theory]
        [MemberData(nameof(DayEndValues))]
        public void DayEnd_Test(DateTime expected, DateTime? testedDate)
        {
            Assert.Equal(expected, testedDate.DayEnd());

            Assert.Throws<ArgumentNullException>(() => TestedDateNull.DayEnd());
            Assert.Equal(TestedDateNull, TestedDateNull.DayEnd(false));
        }

        [Theory]
        [MemberData(nameof(DayEndNextValues))]
        public void DayEndNext_Test(DateTime expected, DateTime? testedDate)
        {
            Assert.Equal(expected, testedDate.DayEndNext());

            Assert.Throws<ArgumentNullException>(() => TestedDateNull.DayEndNext());
            Assert.Equal(TestedDateNull, TestedDateNull.DayEndNext(false));
        }

        [Theory]
        [MemberData(nameof(DayEndPrevValues))]
        public void DayEndPrev_Test(DateTime expected, DateTime? testedDate)
        {
            Assert.Equal(expected, testedDate.DayEndPrev());

            Assert.Throws<ArgumentNullException>(() => TestedDateNull.DayEndPrev());
            Assert.Equal(TestedDateNull, TestedDateNull.DayEndPrev(false));
        }
    }
}