using ITFCodeWA.Core.Data.References;

namespace ITFCodeWA.Data.Finance.References
{
    public class Currency : ReferenceBase
    {
        public int Code { get; set; }

        public string ShortName { get; set; }
    }
}
