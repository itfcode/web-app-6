using ITFCodeWA.Core.Domain.Helpers;
using ITFCodeWA.Core.Domain.Tests.Classes;

namespace ITFCodeWA.Core.Domain.Tests
{
    public class ExpressionFactory_Tests
    {
        private readonly Person george = new() { FirstName = "George", LastName = "Styles", Age = 35, Weight = 98 };
        private readonly Person steve = new() { FirstName = "Steve", LastName = "Moorse", Age = 30, Weight = 75 };
        private readonly Person nick = new() { FirstName = "Nick", LastName = "Brown", Age = 25, Weight = 86 };

        public static IEnumerable<object[]> Ages = new List<object[]>
        {
            new object[] { 20, 25, 30, 35, 40 },
            new object[] { 23, 59, 36, 34, 35 }
        };

        [Theory]
        [MemberData(nameof(Ages))]
        public void Equal_Test(params int[] ages)
        {
            foreach (var age in ages)
            {
                var lambda = ExpressionFactory.Equal<Person>("Age", age);
                Assert.True((george.Age == age) == (lambda.Compile()(george)));
            }
        }

        [Theory]
        [MemberData(nameof(Ages))]
        public void LessThan_Test(params int[] ages)
        {
            foreach (var age in ages)
            {
                var lambda = ExpressionFactory.LessThan<Person>("Age", age);
                Assert.True((george.Age < age) == (lambda.Compile()(george)));
            }
        }

        [Theory]
        [MemberData(nameof(Ages))]
        public void LessThanOrEquals_Test(params int[] ages)
        {
            foreach (var age in ages)
            {
                var lambda = ExpressionFactory.LessThanOrEquals<Person>("Age", age);
                Assert.True((george.Age <= age) == (lambda.Compile()(george)));
            }
        }

        [Theory]
        [MemberData(nameof(Ages))]
        public void GreaterThan_Test(params int[] ages)
        {
            foreach (var age in ages)
            {
                var lambda = ExpressionFactory.GreaterThan<Person>("Age", age);
                Assert.True(george.Age > age == lambda.Compile()(george));
            }
        }

        [Theory]
        [MemberData(nameof(Ages))]
        public void GreaterThanOrEquals_Test(params int[] ages)
        {
            foreach (var age in ages)
            {
                var lambda = ExpressionFactory.GreaterThanOrEquals<Person>("Age", age);
                Assert.True((george.Age >= age) == lambda.Compile()(george));
            }
        }
    }
}