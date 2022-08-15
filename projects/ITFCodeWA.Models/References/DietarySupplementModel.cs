using ITFCodeWA.Core.Models.Common.References;
using ITFCodeWA.Models.Enums;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Models.References
{
    public class DietarySupplementModel : ReferenceBaseModel
    {
        [JsonPropertyName("latinName")]
        [JsonProperty("latinName")]
        public string? LatinName { get; set; }

        [JsonPropertyName("type")]
        [JsonProperty("type")]
        public DietarySupplementType Type { get; set; }
    }
}