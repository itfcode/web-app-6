using ITFCodeWA.Core.Models.Common.References;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Models.Common.References
{
    public class PersonModel : ReferenceBaseModel
    {
        [JsonPropertyName("firstName")]
        [JsonProperty("firstName")]
        public string FirstName { get; set; } = string.Empty;

        [JsonPropertyName("middleName")]
        [JsonProperty("middleName")]
        public string MiddleName { get; set; } = string.Empty;

        [JsonPropertyName("lastName")]
        [JsonProperty("lastName")]
        public string LastName { get; set; } = string.Empty;

        [JsonPropertyName("fullName")]
        [JsonProperty("fullName")]
        public string FullName { get; set; } = string.Empty;
    }
}
