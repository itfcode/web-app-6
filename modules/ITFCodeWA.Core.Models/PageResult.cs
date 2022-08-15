using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Core.Models
{
    public class PageResult<TModel> where TModel : class
    {
        [JsonPropertyName("skip")]
        [JsonProperty("skip")]
        public int Skip { get; set; } = 0;

        [JsonPropertyName("total")]
        [JsonProperty("total")]
        public int Total { get; set; } = 0;

        [JsonPropertyName("items")]
        [JsonProperty("items")]
        public IEnumerable<TModel> Items { get; set; } = Enumerable.Empty<TModel>();
    }
}
