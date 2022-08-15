using ITFCodeWA.Core.Models.Common.Base.Interfaces;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Core.Models.Common.Base
{
    public class EntityModel : IEntityModel
    {
        [JsonPropertyName("id")]
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}