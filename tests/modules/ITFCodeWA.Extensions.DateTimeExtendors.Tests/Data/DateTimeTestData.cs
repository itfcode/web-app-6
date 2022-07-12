using System;
using System.Collections.Generic;
using System.Linq;

namespace ITFCodeWA.Extensions.DateTimeExtendors.Tests
{
    internal static partial class DateTimeTestData
    {
        private static readonly int _valueCount = 50;

        private static readonly int _startRange = -5;

        private static int GetRandomValue() => new Random().Next(-100, 100);

        private static IEnumerable<int> GetRange() => Enumerable.Range(_startRange, _valueCount);
    }
}