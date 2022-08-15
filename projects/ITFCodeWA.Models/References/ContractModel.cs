using ITFCodeWA.Core.Models.Common.References;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Models.References
{
    public class ContractModel : ReferenceBaseModel
    {
        [JsonPropertyName("currencyId")]
        [JsonProperty("currencyId")]
        public int CurrencyId { get; set; }

        [JsonPropertyName("currencyName")]
        [JsonProperty("currencyName")]
        public int CurrencyName { get; set; }

        [JsonPropertyName("contractorId")]
        [JsonProperty("contractorId")]
        public int ContractorId { get; set; }

        [JsonPropertyName("contractorName")]
        [JsonProperty("contractorName")]
        public int ContractorName { get; set; }

        [JsonPropertyName("startDate")]
        [JsonProperty("startDate")]
        public DateTimeOffset StartDate { get; set; }

        [JsonPropertyName("finishDate")]
        [JsonProperty("finishDate")]
        public DateTimeOffset FinishDate { get; set; }

        [JsonPropertyName("totalCost")]
        [JsonProperty("totalCost")]
        public decimal TotalCost { get; set; }
    }
}
