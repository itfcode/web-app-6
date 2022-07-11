using ITFCodeWA.Core.Models.QueryFilters.Interfaces;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Core.Models.QueryFilters
{
    public class QueryOptions
    {
        [JsonPropertyName("sortField")]
        [JsonProperty("sortField")]
        public string SortField { get; init; }

        [JsonPropertyName("isAsc")]
        [JsonProperty("isAsc")]
        public bool IsAsc { get; init; } = true;

        [JsonPropertyName("take")]
        [JsonProperty("take")]
        public int Take { get; init; } = 50;

        [JsonPropertyName("skip")]
        [JsonProperty("skip")]
        public int Skip { get; init; } = 0;

        [JsonPropertyName("filters")]
        [JsonProperty("filters")]
        public List<IQueryFilter> Filters { get; init; } = new List<IQueryFilter>();
    }
}
