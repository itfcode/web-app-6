using ITFCodeWA.Core.Data.Base;
using ITFCodeWA.Core.Data.Documents.Interfaces;

namespace ITFCodeWA.Core.Data.Documents
{
    public abstract class DocumentBase : EntitySync, IDocument
    {
        public int Number { get; set; }
        public DateTimeOffset Date { get; set; }
        public string Comment { get; set; } = string.Empty;
        public bool Commited { get; set; }
        public bool Marked { get; set; }
        public int AuthorId { get; set; }
    }
}
