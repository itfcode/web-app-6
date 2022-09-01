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
        public decimal Max => Math.Round(Rows.Where(x => x.Weight.HasValue && x.Weight > 0).Max(x => x.Weight.Value), 1);

        [JsonPropertyName("min")]
        [JsonProperty("min")]
        public decimal Min => Math.Round(Rows.Where(x => x.Weight.HasValue && x.Weight > 0).Min(x => x.Weight.Value), 1);

        [JsonPropertyName("avg")]
        [JsonProperty("avg")]
        public decimal Avg => Math.Round(Rows.Where(x => x.Weight.HasValue && x.Weight > 0).Average(x => x.Weight.Value), 1);

        [JsonPropertyName("rows")]
        [JsonProperty("rows")]
        public IList<WeightRegistratorRowModel> Rows { get; set; }
    }
}