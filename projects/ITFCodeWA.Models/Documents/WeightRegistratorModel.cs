using ITFCodeWA.Models.Health.Documents.Base;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Models.Documents
{
    public class WeightRegistratorModel : RegistratorBaseModel
    {
        [JsonPropertyName("dateMonth")]
        [JsonProperty("dateMonth")]
        public DateTimeOffset DateMonth { get; set; }

        [JsonPropertyName("max")]
        [JsonProperty("max")]
        public decimal Max => Rows.Where(x => x.Weight.HasValue).Max(x => x.Weight.Value);

        [JsonPropertyName("min")]
        [JsonProperty("min")]
        public decimal Min => Rows.Where(x => x.Weight.HasValue).Min(x => x.Weight.Value);

        [JsonPropertyName("avg")]
        [JsonProperty("avg")]
        public decimal Avg => Math.Round(Rows.Where(x => x.Weight.HasValue).Average(x => x.Weight.Value), 2);

        [JsonPropertyName("rows")]
        [JsonProperty("rows")]
        public IList<WeightRegistratorRowModel> Rows { get; set; }
    }
}