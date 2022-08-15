using System;
using System.Collections.Generic;
using Xunit;

namespace ITFCodeWA.Extensions.DateTimeExtendors.Tests.UnitTests
{
    public partial class DateTimeUnitTests
    {
        public static IEnumerable<object[]> DayOfWeekFirstInMonthValues = DateTimeTestData.GetDayOfWeekFirstInMonthValues();

        [Theory]
        [MemberData(nameof(DayOfWeekFirstInMonthValues))]
        public void FirstMonday_Test(DateTime source) => DayOfWeekFirst_Test(source, source.MondayFirst(), DayOfWeek.Monday);

        [Theory]
        [MemberData(nameof(DayOfWeekFirstInMonthValues))]
        public void TuesdayFirst_Test(DateTime source) => DayOfWeekFirst_Test(source, source.TuesdayFirst(), DayOfWeek.Tuesday);

        [Theory]
        [MemberData(nameof(DayOfWeekFirstInMonthValues))]
        public void WednesdayFirst_Test(DateTime source) => DayOfWeekFirst_Test(source, source.WednesdayFirst(), DayOfWeek.Wednesday);

        [Theory]
        [MemberData(nameof(DayOfWeekFirstInMonthValues))]
        public void ThursdayFirst_Test(DateTime source) => DayOfWeekFirst_Test(source, source.ThursdayFirst(), DayOfWeek.Thursday);

        [Theory]
        [MemberData(nameof(DayOfWeekFirstInMonthValues))]
        public void FridayFirst_Test(DateTime source) => DayOfWeekFirst_Test(source, source.FridayFirst(), DayOfWeek.Friday);

        [Theory]
        [MemberData(nameof(DayOfWeekFirstInMonthValues))]
        public void SaturdayFirst_Test(DateTime source) => DayOfWeekFirst_Test(source, source.SaturdayFirst(), DayOfWeek.Saturday);

        [Theory]
        [MemberData(nameof(DayOfWeekFirstInMonthValues))]
        public void SundayFirst_Test(DateTime source) => DayOfWeekFirst_Test(source, source.SundayFirst(), DayOfWeek.Sunday);

        private void DayOfWeekFirst_Test(DateTime source, DateTime prepared, DayOfWeek dayOfWeek) 
        {
            Assert.Equal(dayOfWeek, prepared.DayOfWeek);
            Assert.True(prepared.Day < 8);
            Assert.Equal(source.Year, prepared.Year);
            Assert.Equal(source.Month, prepared.Month);
        }
    }
}