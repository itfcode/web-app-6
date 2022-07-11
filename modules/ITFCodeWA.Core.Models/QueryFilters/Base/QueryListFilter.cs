using ITFCodeWA.Core.Models.QueryFilters.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Core.Models.QueryFilters.Base
{
    public class QueryListFilter<T> : QueryFilter, IQueryListFilter<T>
    {
        [JsonPropertyName("values")]
        [JsonProperty("values")]
        public List<T> Values { get; init; } = new List<T>();
    }
}
