using ITFCodeWA.Core.Models.QueryFilters.Base;
using ITFCodeWA.Core.Models.QueryFilters.Single.Base.Intrefaces;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Core.Models.QueryFilters.Single.Base
{
    public abstract class QuerySingleFilter<T> : QueryFilter, IQuerySingleFilter<T>
    {
        [JsonPropertyName("value")]
        [JsonProperty("value")]
        public T Value { get; init; } = default;
    }
}
