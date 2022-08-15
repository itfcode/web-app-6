using ITFCodeWA.Core.Models.QueryFilters.Base.Interfaces;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Core.Models.QueryFilters
{
    public class QueryOptions
    {
        [JsonPropertyName("sortField")]
        [JsonProperty("sortField")]
        public string? SortField { get; set; }

        [JsonPropertyName("isAsc")]
        [JsonProperty("isAsc")]
        public bool IsAsc { get; set; } = true;

        [JsonPropertyName("take")]
        [JsonProperty("take")]
        public int Take { get; set; } = 10;

        [JsonPropertyName("skip")]
        [JsonProperty("skip")]
        public int Skip { get; set; } = 0;

        [JsonPropertyName("filters")]
        [JsonProperty("filters")]
        public List<IQueryFilter> Filters { get; set; } = new List<IQueryFilter>();
    }
}
