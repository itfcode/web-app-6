using ITFCodeWA.Core.Models.Common.Documents;

namespace ITFCodeWA.Models.Health.Documents.Base
{
    public class RegistratorBaseModel : DocumentBaseModel
    {
        public int PersonId { get; set; }

        public string PersonFullName { get; set; } = string.Empty;
    }
}