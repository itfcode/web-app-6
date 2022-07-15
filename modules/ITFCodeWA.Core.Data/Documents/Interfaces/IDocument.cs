using ITFCodeWA.Core.Data.Base.Interface;

namespace ITFCodeWA.Core.Data.Documents.Interfaces
{
    public interface IDocument : IEntitySync
    {
        int Number { get; set; }
        DateTimeOffset Date { get; set; }
        string Comment { get; set; }
        bool Commited { get; set; }
        bool Marked { get; set; }
        int AuthorId { get; set; }
    }
}
