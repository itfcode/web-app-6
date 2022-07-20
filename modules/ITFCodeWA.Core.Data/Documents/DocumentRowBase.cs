using ITFCodeWA.Core.Data.Base;
using ITFCodeWA.Core.Data.Documents.Interfaces;

namespace ITFCodeWA.Core.Data.Documents
{
    public abstract class DocumentRowBase : EntitySync, IDocumentRow
    {
        public Guid DocumentId { get; set; }

        public int RowNumber { get; set; }
    }
}
