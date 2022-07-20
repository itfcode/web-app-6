using ITFCodeWA.Core.Data.References;

namespace ITFCodeWA.Data.Common.Reference
{
    public class Person : ReferenceBase
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public DateTimeOffset DateOfBirth { get; set; }
    }
}
