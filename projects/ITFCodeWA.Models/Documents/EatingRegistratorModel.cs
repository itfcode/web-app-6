using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Models.Documents
{
    public class EatingRegistratorModel
    {
        [JsonPropertyName("timeValue")]
        [JsonProperty("timeValue")]
        public string? TimeValue { get; set; }
    }
}
