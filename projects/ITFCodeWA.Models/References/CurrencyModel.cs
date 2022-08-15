using ITFCodeWA.Core.Models.Common.References;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Models.References
{
    public class CurrencyModel : ReferenceBaseModel
    {
        [JsonPropertyName("code")]
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonPropertyName("shortName")]
        [JsonProperty("shortName")]
        public string ShortName { get; set; }
    }
}