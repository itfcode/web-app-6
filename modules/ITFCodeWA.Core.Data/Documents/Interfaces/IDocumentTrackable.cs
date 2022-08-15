using ITFCodeWA.Core.Data.Base.Interface;

namespace ITFCodeWA.Core.Data.Documents.Interfaces
{
    public interface IDocumentTrackable : ITrackable
    {
        DateTimeOffset CommitedOn { get; set; }
        DateTimeOffset MarkedOn { get; set; }
    }
}
