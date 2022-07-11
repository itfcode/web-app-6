using ITFCodeWA.Core.Models.QueryFilters.Interfaces;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Core.Models.QueryFilters.Base
{
    public abstract class QueryRangeFilter<T> : QueryFilter, IQueryRangeFilter<T>
    {
        [JsonPropertyName("from")]
        [JsonProperty("from")]
        public T From { get; init; }

        [JsonPropertyName("to")]
        [JsonProperty("to")]
        public T To { get; init; }
    }
}