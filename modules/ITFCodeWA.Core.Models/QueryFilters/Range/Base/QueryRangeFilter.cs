using ITFCodeWA.Core.Models.QueryFilters.Base;
using ITFCodeWA.Core.Models.QueryFilters.Range.Base.Interfaces;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Core.Models.QueryFilters.Range.Base
{
    public class QueryRangeFilter<T> : QueryFilter, IQueryRangeFilter<T>
    {
        [JsonPropertyName("values")]
        [JsonProperty("values")]
        public List<T> Values { get; init; } = new List<T>();
    }
}
