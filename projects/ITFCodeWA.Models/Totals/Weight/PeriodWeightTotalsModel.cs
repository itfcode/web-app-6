using ITFCodeWA.Core.Models.Common.Base;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Models.Totals.Weight
{
    public class PeriodWeightTotalsModel : TotalModel
    {
        [JsonPropertyName("period")]
        [JsonProperty("period")]
        public int Period { get; init; }

        [JsonPropertyName("periodDate")]
        [JsonProperty("periodDate")]
        public DateTimeOffset PeriodDate { get; init; }

        [JsonPropertyName("min")]
        [JsonProperty("min")]
        public decimal Min { get; init; }

        [JsonPropertyName("max")]
        [JsonProperty("max")]
        public decimal Max { get; init; }

        [JsonPropertyName("avg")]
        [JsonProperty("avg")]
        public decimal Avg { get; init; }

        [JsonPropertyName("type")]
        [JsonProperty("type")]
        public PeriodWeightTotalType Type { get; init; }

        [JsonPropertyName("subTotals")]
        [JsonProperty("subTotals")]
        public IList<PeriodWeightTotalsModel> SubTotals { get; init; } = new List<PeriodWeightTotalsModel>();

        [JsonPropertyName("minAvg")]
        [JsonProperty("minAvg")]
        public decimal MinAvg => GetMin(s => s.Avg);

        [JsonPropertyName("maxAvg")]
        [JsonProperty("maxAvg")]
        public decimal MaxAvg => GetMax(s => s.Avg);

        [JsonPropertyName("minMin")]
        [JsonProperty("minMin")]
        public decimal MinMin => GetMin(s => s.Min);

        [JsonPropertyName("maxMin")]
        [JsonProperty("maxMin")]
        public decimal MaxMin => GetMax(s => s.Min);

        [JsonPropertyName("minMax")]
        [JsonProperty("minMax")]
        public decimal MinMax => GetMin(s => s.Max);

        [JsonPropertyName("maxMax")]
        [JsonProperty("maxMax")]
        public decimal MaxMax => GetMax(s => s.Max);

        decimal GetMin(Func<PeriodWeightTotalsModel, decimal> selector)
            => SubTotals is not null && SubTotals.Count > 0 ? SubTotals.Min(selector) : 0;

        decimal GetMax(Func<PeriodWeightTotalsModel, decimal> selector)
            => SubTotals is not null && SubTotals.Count > 0 ? SubTotals.Max(selector) : 0;
    }
}