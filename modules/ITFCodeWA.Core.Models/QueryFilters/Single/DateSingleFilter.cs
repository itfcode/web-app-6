using ITFCodeWA.Core.Models.QueryFilters.Single.Base;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Core.Models.QueryFilters.Single
{
    public class DateSingleFilter : QuerySingleFilter<DateTimeOffset>
    {
        [JsonPropertyName("matchMode")]
        [JsonProperty("matchMode")]
        public DateFilterMatchMode MatchMode { get; init; } = DateFilterMatchMode.Equals;
    }
}