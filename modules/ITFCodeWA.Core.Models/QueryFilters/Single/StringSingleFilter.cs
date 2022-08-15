using ITFCodeWA.Core.Models.QueryFilters.Single.Base;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Core.Models.QueryFilters.Single
{
    public class StringSingleFilter : QuerySingleFilter<string>
    {
        [JsonPropertyName("matchMode")]
        [JsonProperty("matchMode")]
        public StringFilterMatchMode MatchMode { get; set; } = StringFilterMatchMode.Contains;
    }
}