using ITFCodeWA.Models.Health.Documents.Base;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Models.Documents
{
    public class DishRegistratorRowModel : RegistratorRowBaseModel
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

        [JsonPropertyName("caloriesPer100")]
        [JsonProperty("caloriesPer100")]
        public decimal CaloriesPer100 { get; set; }

        [JsonPropertyName("calories")]
        [JsonProperty("calories")]
        public decimal Calories { get; set; }
    }
}