using ITFCodeWA.Core.Models.Common.Base.Interfaces;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Core.Models.Common.Base
{
    public abstract class EntitySyncModel : IEntitySyncModel
    {
        [JsonPropertyName("id")]
        [JsonProperty("id")]
        public Guid Id { get; set; }
    }
}