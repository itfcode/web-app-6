using ITFCodeWA.Core.Models.QueryFilters.Base.Interfaces;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Core.Models.QueryFilters.Base
{
    public abstract class QueryFilter : IQueryFilter
    {
        [JsonPropertyName("propertyName")]
        [JsonProperty("propertyName")]
        public string PropertyName { get; init; } = string.Empty;

        [JsonPropertyName("typeFilter")]
        [JsonProperty("typeFilter")]
        public string Type => GetType().Name;
    }
}