using ITFCodeWA.Core.Models.Common.References;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Models.References
{
    public class FoodModel : ReferenceBaseModel
    {
        [JsonPropertyName("proteins")]
        [JsonProperty("proteins")]
        public decimal Proteins { get; set; }

        [JsonPropertyName("fats")]
        [JsonProperty("fats")]
        public decimal Fats { get; set; }

        [JsonPropertyName("carbohydrates")]
        [JsonProperty("carbohydrates")]
        public decimal Carbohydrates { get; set; }

        [JsonPropertyName("calories")]
        [JsonProperty("calories")]
        public decimal Calories { get; set; }

        [JsonPropertyName("foodGroupId")]
        [JsonProperty("foodGroupId")]
        public int FoodGroupId { get; set; }

        [JsonPropertyName("foodGroupName")]
        [JsonProperty("foodGroupName")]
        public string FoodGroupName { get; set; }
    }
}