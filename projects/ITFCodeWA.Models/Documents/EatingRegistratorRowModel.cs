using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Models.Documents
{
    public class EatingRegistratorRowModel
    {
        [JsonPropertyName("foodId")]
        [JsonProperty("foodId")]
        public int FoodId { get; set; }

        [JsonPropertyName("foodName")]
        [JsonProperty("foodName")]
        public string? FoodName { get; set; }

        [JsonPropertyName("weight")]
        [JsonProperty("weight")]
        public decimal Weight { get; set; }
    }
}
