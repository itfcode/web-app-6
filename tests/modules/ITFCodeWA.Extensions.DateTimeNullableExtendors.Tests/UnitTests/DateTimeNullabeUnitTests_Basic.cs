using ITFCodeWA.Extensions.DateTimeNullableExtendors.Tests.Data;
using System.Reflection;

namespace ITFCodeWA.Extensions.DateTimeNullableExtendors.Tests
{
    public partial class DateTimeNullabeUnitTests
    {
        private readonly DateTime? TestedDateNull = default;

        public static IEnumerable<object[]> AddValues => DateTimeNullableTestData.GetAddValues();
        public static IEnumerable<object[]> AddTicksValues => DateTimeNullableTestData.GetAddTicksValues();
        public static IEnumerable<object[]> AddMillisecondsValues => DateTimeNullableTestData.GetAddMillisecondsValues();
        public static IEnumerable<object[]> AddSecondsValues => DateTimeNullableTestData.GetAddSecondsValues();
        public static IEnumerable<object[]> AddMinutesValues => DateTimeNullableTestData.GetAddMinutesValues();
        public static IEnumerable<object[]> AddHoursValues => DateTimeNullableTestData.GetAddHoursValues();
        public static IEnumerable<object[]> AddDaysValues => DateTimeNullableTestData.GetAddDaysValues();
        public static IEnumerable<object[]> AddMonthsValues => DateTimeNullableTestData.GetAddMonthsValues();
        public static IEnumerable<object[]> AddYearsValues => DateTimeNullableTestData.GetAddYearsValues();

        [Theory]
        [MemberData(nameof(AddValues))]
        public void Add_Test(DateTime? testedDate, TimeSpan timeSpan)
        {
            Assert.Equal(testedDate.Value.Add(timeSpan), testedDate.Add(timeSpan));

            if (timeSpan == TimeSpan.Zero)
                Assert.Equal(testedDate, testedDate.Add(timeSpan));
            else
                Assert.NotEqual(testedDate, testedDate.Add(timeSpan));

            Assert.Throws<ArgumentNullException>(() => TestedDateNull.Add(timeSpan));
            Assert.Equal(TestedDateNull, TestedDateNull.Add(timeSpan, false));
        }

        [Theory]
        [MemberData(nameof(AddTicksValues))]
        public void AddTicks_Test(DateTime? testedDate, int ticks)
            => BasicMethod_Test(testedDate, nameof(DateTimeNullableExtensions.AddTicks), ticks);

        [Theory]
        [MemberData(nameof(AddMillisecondsValues))]
        public void AddMilliseconds_Test(DateTime? testedDate, int milliseconds)
            => BasicMethod_Test(testedDate, nameof(DateTimeNullableExtensions.AddMilliseconds), milliseconds);

        [Theory]
        [MemberData(nameof(AddSecondsValues))]
        public void AddSeconds_Test(DateTime? testedDate, int seconds)
            => BasicMethod_Test(testedDate, nameof(DateTimeNullableExtensions.AddSeconds), seconds);

        [Theory]
        [MemberData(nameof(AddMinutesValues))]
        public void AddMinutes_Test(DateTime? testedDate, int minutes)
            => BasicMethod_Test(testedDate, nameof(DateTimeNullableExtensions.AddMinutes), minutes);

        [Theory]
        [MemberData(nameof(AddHoursValues))]
        public void AddHours_Test(DateTime? testedDate, int hours)
            => BasicMethod_Test(testedDate, nameof(DateTimeNullableExtensions.AddHours), hours);

        [Theory]
        [MemberData(nameof(AddDaysValues))]
        public void AddDays_Test(DateTime? testedDate, int hours)
            => BasicMethod_Test(testedDate, nameof(DateTimeNullableExtensions.AddDays), hours);

        [Theory]
        [MemberData(nameof(AddMonthsValues))]
        public void AddMonths_Test(DateTime? testedDate, int months)
            => BasicMethod_Test(testedDate, nameof(DateTimeNullableExtensions.AddMonths), months);

        [Theory]
        [MemberData(nameof(AddYearsValues))]
        public void AddYears_Test(DateTime? testedDate, int years)
            => BasicMethod_Test(testedDate, nameof(DateTimeNullableExtensions.AddYears), years);

        private void BasicMethod_Test(DateTime? date, string methodName, int value)
        {
            var expected = (DateTime?)typeof(DateTime)
                .GetMethod(methodName)
                .Invoke(date.Value, new object[] { value });

            var method = GetExtensionMethod(methodName);
            var actual = (DateTime?)method.Invoke(null, new object[] { date, value, true });

            Assert.Equal(expected, actual);

            if (value == 0)
                Assert.Equal(date, actual);
            else
                Assert.NotEqual(date, actual);

            var actualNull = (DateTime?)method.Invoke(null, new object[] { TestedDateNull, value, false });
            Assert.Equal(TestedDateNull, actualNull);

            var exception = Assert.Throws<TargetInvocationException>(() => method.Invoke(null, new object[] { TestedDateNull, value, true }));
            Assert.Equal(typeof(ArgumentNullException), exception.InnerException.GetType());
        }

        private MethodInfo GetExtensionMethod(string methodName)
        {
            var method = typeof(DateTimeNullableExtensions).GetMethod(methodName);

            if (method == null)
                throw new Exception($"Method {methodName}() not found");

            return method;
        }
    }
}