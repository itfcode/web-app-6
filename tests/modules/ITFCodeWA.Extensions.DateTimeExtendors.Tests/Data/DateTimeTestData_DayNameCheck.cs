using System;
using System.Collections.Generic;
using System.Linq;

namespace ITFCodeWA.Extensions.DateTimeExtendors.Tests
{
    internal static partial class DateTimeTestData
    {
        public static DateTime MondayDate = new DateTime(2022, 8, 1);
        public static DateTime TuesdayDate = MondayDate.AddDays(1);
        public static DateTime WednesdayDate = TuesdayDate.AddDays(1);
        public static DateTime ThursdayDate = WednesdayDate.AddDays(1);
        public static DateTime FridayDate = ThursdayDate.AddDays(1);
        public static DateTime SaturdayDate = FridayDate.AddDays(1);
        public static DateTime SundayDate = SaturdayDate.AddDays(1);

        public static IEnumerable<object[]> GetIsMondayValues() => GetRange()
            .Select(i => new object[] { MondayDate.AddDays(7 * GetRandomValue()) })
            .ToList();

        public static IEnumerable<object[]> GetIsTuesdayValues() => GetRange()
            .Select(i => new object[] { TuesdayDate.AddDays(7 * GetRandomValue()) })
            .ToList();

        public static IEnumerable<object[]> GetIsWednesdayValues() => GetRange()
            .Select(i => new object[] { WednesdayDate.AddDays(7 * GetRandomValue()) })
            .ToList();

        public static IEnumerable<object[]> GetIsThursdayValues() => GetRange()
            .Select(i => new object[] { ThursdayDate.AddDays(7 * GetRandomValue()) })
            .ToList();

        public static IEnumerable<object[]> GetIsFridayValues() => GetRange()
            .Select(i => new object[] { FridayDate.AddDays(7 * GetRandomValue()) })
            .ToList();

        public static IEnumerable<object[]> GetIsSaturdayValues() => GetRange()
            .Select(i => new object[] { SaturdayDate.AddDays(7 * GetRandomValue()) })
            .ToList();

        public static IEnumerable<object[]> GetIsSundayValues() => GetRange()
            .Select(i => new object[] { SundayDate.AddDays(7 * GetRandomValue()) })
            .ToList();
    }
}