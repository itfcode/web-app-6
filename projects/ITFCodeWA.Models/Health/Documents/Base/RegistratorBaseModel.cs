using ITFCodeWA.Core.Models.Common.Documents;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Models.Health.Documents.Base
{
    public class RegistratorBaseModel : DocumentBaseModel
    {
        [JsonPropertyName("personId")]
        [JsonProperty("personId")]
        public int PersonId { get; set; }

        [JsonPropertyName("personFullName")]
        [JsonProperty("personFullName")]
        public string PersonFullName { get; set; } = string.Empty;
    }
}