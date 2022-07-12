namespace ITFCodeWA.Extensions.DateTimeNullableExtendors.Tests
{
    public partial class DateTimeNullabeUnitTests
    {

        private void DayOfWeekLast_Test(DateTime? source, DateTime? prepared, DayOfWeek dayOfWeek)
        {
            var nextMonthStart = new DateTime(source.Value.Year, source.Value.Month, 1).AddMonths(1);

            Assert.Equal(dayOfWeek, prepared.Value.DayOfWeek);
            Assert.Equal(source.Value.Year, prepared.Value.Year);
            Assert.Equal(source.Value.Month, prepared.Value.Month);
            Assert.True(prepared < nextMonthStart);
            Assert.True(prepared.AddDays(7) >= nextMonthStart);
        }
    }
}