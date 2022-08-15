using ITFCodeWA.Core.Models.Common.References;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Models.References
{
    public class DishModel : ReferenceBaseModel
    {
        [JsonPropertyName("components")]
        [JsonProperty("components")]
        public ICollection<FoodModel>? Components { get; set; }
    }
}
