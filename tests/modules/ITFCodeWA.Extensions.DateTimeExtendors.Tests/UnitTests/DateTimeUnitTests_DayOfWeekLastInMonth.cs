using System;
using System.Collections.Generic;
using Xunit;

namespace ITFCodeWA.Extensions.DateTimeExtendors.Tests.UnitTests
{
    public partial class DateTimeUnitTests
    {
        public static IEnumerable<object[]> DayOfWeekLastInMonthValues = DateTimeTestData.GetDayOfWeekLastInMonthValues();

        [Theory]
        [MemberData(nameof(DayOfWeekLastInMonthValues))]
        public void LastMonday_Test(DateTime source) => DayOfWeekLast_Test(source, source.MondayLast(), DayOfWeek.Monday);

        [Theory]
        [MemberData(nameof(DayOfWeekLastInMonthValues))]
        public void TuesdayLast_Test(DateTime source) => DayOfWeekLast_Test(source, source.TuesdayLast(), DayOfWeek.Tuesday);

        [Theory]
        [MemberData(nameof(DayOfWeekLastInMonthValues))]
        public void WednesdayLast_Test(DateTime source) => DayOfWeekLast_Test(source, source.WednesdayLast(), DayOfWeek.Wednesday);

        [Theory]
        [MemberData(nameof(DayOfWeekLastInMonthValues))]
        public void ThursdayLast_Test(DateTime source) => DayOfWeekLast_Test(source, source.ThursdayLast(), DayOfWeek.Thursday);

        [Theory]
        [MemberData(nameof(DayOfWeekLastInMonthValues))]
        public void FridayLast_Test(DateTime source) => DayOfWeekLast_Test(source, source.FridayLast(), DayOfWeek.Friday);

        [Theory]
        [MemberData(nameof(DayOfWeekLastInMonthValues))]
        public void SaturdayLast_Test(DateTime source) => DayOfWeekLast_Test(source, source.SaturdayLast(), DayOfWeek.Saturday);

        [Theory]
        [MemberData(nameof(DayOfWeekLastInMonthValues))]
        public void SundayLast_Test(DateTime source) => DayOfWeekLast_Test(source, source.SundayLast(), DayOfWeek.Sunday);

        private void DayOfWeekLast_Test(DateTime source, DateTime prepared, DayOfWeek dayOfWeek)
        {
            var nextMonthStart = new DateTime(source.Year, source.Month, 1).AddMonths(1);

            Assert.Equal(dayOfWeek, prepared.DayOfWeek);
            Assert.Equal(source.Year, prepared.Year);
            Assert.Equal(source.Month, prepared.Month);
            Assert.True(prepared < nextMonthStart);
            Assert.True(prepared.AddDays(7) >= nextMonthStart);
        }
    }
}
