using ITFCodeWA.Core.Models.Common.Base;
using ITFCodeWA.Core.Models.Common.Documents.Interfaces;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Core.Models.Common.Documents
{
    public abstract class DocumentBaseModel : EntitySyncModel, IDocumentModel
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

        [JsonPropertyName("authorFullName")]
        [JsonProperty("authorFullName")]
        public string AuthorFullName { get; set; } = string.Empty;
    }
}