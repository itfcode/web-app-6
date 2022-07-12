using ITFCodeWA.Extensions.DateTimeOffsetExtendors.Tests.Data;

namespace ITFCodeWA.Extensions.DateTimeOffsetExtendors.Tests.UnitTests
{
    public partial class DateTimeOffsetUnitTests
    {
        public static IEnumerable<object[]> DayOfWeekFirstInMonthValues => TestData.GetDayOfWeekFirstInMonthValues();

        [Theory]
        [MemberData(nameof(DayOfWeekFirstInMonthValues))]
        public void FirstMonday_Test(DateTimeOffset source) => DayOfWeekFirst_Test(source, source.MondayFirst(), DayOfWeek.Monday);

        [Theory]
        [MemberData(nameof(DayOfWeekFirstInMonthValues))]
        public void TuesdayFirst_Test(DateTimeOffset source) => DayOfWeekFirst_Test(source, source.TuesdayFirst(), DayOfWeek.Tuesday);

        [Theory]
        [MemberData(nameof(DayOfWeekFirstInMonthValues))]
        public void WednesdayFirst_Test(DateTimeOffset source) => DayOfWeekFirst_Test(source, source.WednesdayFirst(), DayOfWeek.Wednesday);

        [Theory]
        [MemberData(nameof(DayOfWeekFirstInMonthValues))]
        public void ThursdayFirst_Test(DateTimeOffset source) => DayOfWeekFirst_Test(source, source.ThursdayFirst(), DayOfWeek.Thursday);

        [Theory]
        [MemberData(nameof(DayOfWeekFirstInMonthValues))]
        public void FridayFirst_Test(DateTimeOffset source) => DayOfWeekFirst_Test(source, source.FridayFirst(), DayOfWeek.Friday);

        [Theory]
        [MemberData(nameof(DayOfWeekFirstInMonthValues))]
        public void SaturdayFirst_Test(DateTimeOffset source) => DayOfWeekFirst_Test(source, source.SaturdayFirst(), DayOfWeek.Saturday);

        [Theory]
        [MemberData(nameof(DayOfWeekFirstInMonthValues))]
        public void SundayFirst_Test(DateTimeOffset source) => DayOfWeekFirst_Test(source, source.SundayFirst(), DayOfWeek.Sunday);

        private void DayOfWeekFirst_Test(DateTimeOffset source, DateTimeOffset prepared, DayOfWeek dayOfWeek)
        {
            Assert.Equal(dayOfWeek, prepared.DayOfWeek);
            Assert.Equal(prepared.Date, prepared);
            Assert.Equal(source.Offset, prepared.Offset);
            Assert.True(prepared.Day < 8);
            Assert.Equal(source.Year, prepared.Year);
            Assert.Equal(source.Month, prepared.Month);
        }
    }
}
