using ITFCodeWA.Core.Models.QueryFilters.Base;
using ITFCodeWA.Core.Models.QueryFilters.Diapason.Base.Intrefaces;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Core.Models.QueryFilters.Diapason.Base
{
    public abstract class QueryDiapasonFilter<T> : QueryFilter, IQueryDiapasonFilter<T>
    {
        [JsonPropertyName("from")]
        [JsonProperty("from")]
        public T From { get; init; }

        [JsonPropertyName("to")]
        [JsonProperty("to")]
        public T To { get; init; }
    }
}