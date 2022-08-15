namespace ITFCodeWA.ClientMudBlazor.Tests
{
    using ITFCodeWA.ClientMudBlazor.Services.Api;
    using ITFCodeWA.Core.Models.QueryFilters;
    using ITFCodeWA.Core.Models.QueryFilters.Base.Interfaces;

    public class QueryStringFactory_Tests
    {
        private readonly string host = "https://api.com";

        [Fact]
        public void If_QueryOptions_Is_Null_Then_Uri_Should_Be_Not_Changed()
        {
            var uri = (string)host.Clone();

            QueryOptions queryOptions = null;

            Assert.Equal(uri, QueryStringFactory.Generate(uri, queryOptions));
        }

        [Fact]
        public void If_QueryOptions_Is_Not_Null_Then_Uri_Should_Be_Changed()
        {
            var uri = (string)host.Clone();

            QueryOptions queryOptions = CreateQueryOptions();

            var actual = QueryStringFactory.Generate(uri, queryOptions);
            Assert.NotEqual(uri, actual);

            Assert.Contains($"skip={queryOptions.Skip}&", actual);
            Assert.Contains($"&take={queryOptions.Take}", actual);
            Assert.Contains($"&sortField={queryOptions.SortField}", actual);
            Assert.Contains($"&isAsc={queryOptions.IsAsc}", actual);
        }

        [Fact]
        public void SingleFilter_Test() 
        {
            QueryOptions queryOptions = CreateQueryOptions();
        }

        private QueryOptions CreateQueryOptions() 
        {
            return new QueryOptions
            {
                IsAsc = false,
                Skip = 15,
                Take = 30,
                SortField = "Description",
                Filters = new List<IQueryFilter>()
            };
        }
    }
}
