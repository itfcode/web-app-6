namespace ITFCodeWA.Extensions.DateTimeNullableExtendors.Tests
{
    public partial class DateTimeNullabeUnitTests
    {


        private void DayOfWeekFirst_Test(DateTime? source, DateTime? prepared, DayOfWeek dayOfWeek)
        {
            Assert.Equal(dayOfWeek, prepared.Value.DayOfWeek);
            Assert.True(prepared.Value.Day < 8);
            Assert.Equal(source.Value.Year, prepared.Value.Year);
            Assert.Equal(source.Value.Month, prepared.Value.Month);
        }
    }
}