using ITFCodeWA.Core.Data.Base;

namespace ITFCodeWA.Data.Common.Reference
{
    public class Person : Entity
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public DateTimeOffset DateOfBirth { get; set; }
    }
}
