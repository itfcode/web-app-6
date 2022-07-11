using ITFCodeWA.Core.Models.QueryFilters.Base;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Core.Models.QueryFilters.NumericFilters
{
    public class NumericFilter : QueryFilter<double>
    {
        [JsonPropertyName("matchMode")]
        [JsonProperty("matchMode")]
        public NumericFilterMatchMode MatchMode { get; init; } = NumericFilterMatchMode.Equals;
    }
}
