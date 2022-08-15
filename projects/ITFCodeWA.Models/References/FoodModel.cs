﻿using ITFCodeWA.Core.Models.Common.References;
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

        [JsonPropertyName("groupId")]
        [JsonProperty("groupId")]
        public int GroupId { get; set; }

        [JsonPropertyName("groupName")]
        [JsonProperty("groupName")]
        public int GroupName { get; set; }
    }
}