using ITFCodeWA.Core.Models.Common.Base;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Core.Models.Common.Documents
{
    public abstract class DocumentModel : EntitySyncModel
    {
        [JsonPropertyName("number")]
        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonPropertyName("date")]
        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonPropertyName("comment")]
        [JsonProperty("comment")]
        public string Comment { get; set; } = string.Empty;

        [JsonPropertyName("commited")]
        [JsonProperty("commited")]
        public bool Commited { get; set; }

        [JsonPropertyName("marked")]
        [JsonProperty("marked")]
        public bool Marked { get; set; }

        [JsonPropertyName("authorId")]
        [JsonProperty("authorId")]
        public int AuthorId { get; set; }
    }
}
