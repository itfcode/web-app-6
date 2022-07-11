using ITFCodeWA.Core.Models.QueryFilters.Interfaces;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Core.Models.QueryFilters.Base
{
    public abstract class QueryFilter : IQueryFilter
    {
        [JsonPropertyName("propertyName")]
        [JsonProperty("propertyName")]
        public string PropertyName { get; init; }

        [JsonPropertyName("typeFilter")]
        [JsonProperty("typeFilter")]
        public string Type => GetType().Name;
    }

    public abstract class QueryFilter<T> : QueryFilter, IQueryFilter<T>
    {
        [JsonPropertyName("value")]
        [JsonProperty("value")]
        public T Value { get; init; }
    }
}
