using ITFCodeWA.Core.Models.Common.Base;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Core.Models.Common.Documents
{
    public abstract class DocumentRowModel : EntitySyncModel
    {
        [JsonPropertyName("documentId")]
        [JsonProperty("documentId")]
        public Guid DocumentId { get; set; }
    }
}
