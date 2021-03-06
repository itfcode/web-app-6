using ITFCodeWA.Core.Models.Common.References;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Models.Finance.Reference
{
    public class GoodModel : ReferenceBaseModel
    {
        [JsonPropertyName("revenueItemId")]
        [JsonProperty("revenueItemId")]
        public int? RevenueItemId { get; set; }

        [JsonPropertyName("revenueItemName")]
        [JsonProperty("revenueItemName")]
        public string? RevenueItemName { get; set; }

        [JsonPropertyName("expenseItemId")]
        [JsonProperty("expenseItemId")]
        public int? ExpenseItemId { get; set; }

        [JsonPropertyName("expenseItemName")]
        [JsonProperty("expenseItemName")]
        public string? ExpenseItemName { get; set; }
    }
}