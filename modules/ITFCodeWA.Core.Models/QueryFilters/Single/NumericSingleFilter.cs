using ITFCodeWA.Core.Models.QueryFilters.Single.Base;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Core.Models.QueryFilters.Single
{
    public class NumericSingleFilter : QuerySingleFilter<double>
    {
        [JsonPropertyName("matchMode")]
        [JsonProperty("matchMode")]
        public NumericFilterMatchMode MatchMode { get; init; } = NumericFilterMatchMode.Equals;
    }
}