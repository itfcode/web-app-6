using System;
using System.Collections.Generic;
using Xunit;

namespace ITFCodeWA.Extensions.DateTimeExtendors.Tests.UnitTests
{
    public partial class DateTimeUnitTests
    {
        public static IEnumerable<object[]> IsMondayValues => DateTimeTestData.GetIsMondayValues();
        public static IEnumerable<object[]> IsTuesdayValues => DateTimeTestData.GetIsTuesdayValues();
        public static IEnumerable<object[]> IsWednesdayValues => DateTimeTestData.GetIsWednesdayValues();
        public static IEnumerable<object[]> IsThursdayValues => DateTimeTestData.GetIsThursdayValues();
        public static IEnumerable<object[]> IsFridayValues => DateTimeTestData.GetIsFridayValues();
        public static IEnumerable<object[]> IsSaturdayValues => DateTimeTestData.GetIsSaturdayValues();
        public static IEnumerable<object[]> IsSundayValues => DateTimeTestData.GetIsSundayValues();

        [Theory]
        [MemberData(nameof(IsMondayValues))]
        public void IsModay_Test(DateTime source) => IsWeekOfDay_Test(source, DayOfWeek.Monday, d => d.IsMonday());

        [Theory]
        [MemberData(nameof(IsTuesdayValues))]
        public void IsTuesday_Test(DateTime source) => IsWeekOfDay_Test(source, DayOfWeek.Tuesday, d => d.IsTuesday());

        [Theory]
        [MemberData(nameof(IsWednesdayValues))]
        public void IsWednesday_Test(DateTime source) => IsWeekOfDay_Test(source, DayOfWeek.Wednesday, d => d.IsWednesday());

        [Theory]
        [MemberData(nameof(IsThursdayValues))]
        public void IsThursday_Test(DateTime source) => IsWeekOfDay_Test(source, DayOfWeek.Thursday, d => d.IsThursday());

        [Theory]
        [MemberData(nameof(IsFridayValues))]
        public void IsFriday_Test(DateTime source) => IsWeekOfDay_Test(source, DayOfWeek.Friday, d => d.IsFriday());

        [Theory]
        [MemberData(nameof(IsSaturdayValues))]
        public void IsSaturday_Test(DateTime source) => IsWeekOfDay_Test(source, DayOfWeek.Saturday, d => d.IsSaturday());

        [Theory]
        [MemberData(nameof(IsSundayValues))]
        public void IsSunday_Test(DateTime source) => IsWeekOfDay_Test(source, DayOfWeek.Sunday, d => d.IsSunday());

        [Theory]
        [MemberData(nameof(IsSaturdayValues))]
        public void IsWeekEnds_Saturday_Test(DateTime source) => Assert.True(source.IsWeekEnds());

        [Theory]
        [MemberData(nameof(IsSundayValues))]
        public void IsWeekEnds_Sunday_Test(DateTime source) => Assert.True(source.IsWeekEnds());

        [Theory]
        [MemberData(nameof(IsMondayValues))]
        [MemberData(nameof(IsTuesdayValues))]
        [MemberData(nameof(IsWednesdayValues))]
        [MemberData(nameof(IsThursdayValues))]
        [MemberData(nameof(IsFridayValues))]
        public void IsWeekEnds_Test(DateTime source) => Assert.False(source.IsWeekEnds());

        private void IsWeekOfDay_Test(DateTime source, DayOfWeek dayOfWeek, Func<DateTime, bool> func)
        {
            Assert.Equal(dayOfWeek, source.DayOfWeek);
            Assert.True(func(source));
        }
    }
}