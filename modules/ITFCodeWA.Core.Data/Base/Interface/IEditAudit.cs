namespace ITFCodeWA.Core.Data.Base.Interface
{
    public interface IEditAudit
    {
        DateTime? CreatedOn { get; set; }
        DateTime? ModifiedOn { get; set; }
        int? AuthorId { get; set; }
    }
}
