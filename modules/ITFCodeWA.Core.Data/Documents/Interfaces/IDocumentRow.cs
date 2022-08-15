using ITFCodeWA.Core.Data.Base.Interface;

namespace ITFCodeWA.Core.Data.Documents.Interfaces
{
    public interface IDocumentRow : IEntitySync
    {
        Guid DocumentId { get; set; }
        int RowNumber { get; set; }
    }
}