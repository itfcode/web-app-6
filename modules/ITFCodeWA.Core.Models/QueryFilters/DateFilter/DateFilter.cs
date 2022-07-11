using ITFCodeWA.Core.Models.QueryFilters.Base;
using Newtonsoft.Json;
using System;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Core.Models.QueryFilters.DateFilter
{
    public class DateFilter : QueryFilter<DateTimeOffset>
    {
        [JsonPropertyName("matchMode")]
        [JsonProperty("matchMode")]
        public DateFilterMatchMode MatchMode { get; init; } = DateFilterMatchMode.Equals;
    }
}