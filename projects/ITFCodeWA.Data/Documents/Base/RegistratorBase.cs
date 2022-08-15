using ITFCodeWA.Core.Data.Documents;
using ITFCodeWA.Data.References;

namespace ITFCodeWA.Data.Health.Documents.Base
{
    public class RegistratorBase : DocumentBase
    {
        public int PersonId { get; set; }

        public Person? Person { get; set; }
    }
}
