using ITFCodeWA.Core.Models.Common.References;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Models.References
{
    public class ContractorModel : ReferenceBaseModel
    {
        [JsonPropertyName("taxNumber")]
        [JsonProperty("taxNumber")]
        public string TaxNumber { get; set; }
    }
}
