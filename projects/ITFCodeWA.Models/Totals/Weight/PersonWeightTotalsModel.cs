using ITFCodeWA.Core.Models.Common.Base;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Models.Totals.Weight
{
    public class PersonWeightTotalsModel : TotalModel
    {
        [JsonPropertyName("personId")]
        [JsonProperty("personId")]
        public int PersonId { get; set; }

        [JsonPropertyName("personFullname")]
        [JsonProperty("personFullname")]
        public string PersonFullname { get; set; }

        [JsonPropertyName("totals")]
        [JsonProperty("totals")]
        public IList<PeriodWeightTotalsModel> Totals { get; set; }

        [JsonPropertyName("weekTotals")]
        [JsonProperty("weekTotals")]
        public IList<WeekWeightTotalsModel> WeekTotals { get; set; }
    }
}