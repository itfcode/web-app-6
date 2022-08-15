using ITFCodeWA.Core.Models.Common.References;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ITFCodeWA.Models.References
{
    public class ExpenseItemModel : ReferenceBaseModel
    {
        [JsonPropertyName("groupId")]
        [JsonProperty("groupId")]
        public int GroupId { get; set; }

        [JsonPropertyName("groupName")]
        [JsonProperty("groupName")]
        public int GroupName { get; set; }
    }
}