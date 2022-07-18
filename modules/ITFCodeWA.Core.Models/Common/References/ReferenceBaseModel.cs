using ITFCodeWA.Core.Models.Common.Base;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Core.Models.Common.References
{
    public abstract class ReferenceBaseModel : EntityModel
    {
        [JsonPropertyName("name")]
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonPropertyName("comment")]
        [JsonProperty("comment")]
        public string? Comment { get; set; }
    }
}