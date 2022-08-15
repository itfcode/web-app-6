using ITFCodeWA.Models.References;

namespace ITFCodeWA.InitialData.Data.Common.References
{
    internal class PersonList
    {
        public static readonly PersonModel Johnson = new PersonModel
        {
            FirstName = "Erick",
            MiddleName = "Ashton",
            LastName = "Johnson",
            Utr = 111222333444,
            DateOfBirth = new DateTime(1974, 7, 6),
        };

        public static readonly PersonModel Mendel = new PersonModel
        {
            FirstName = "David",
            MiddleName = "Aaron",
            LastName = "Mendel",
            Utr = 111222333555,
            DateOfBirth = new DateTime(1975, 6, 20),
        };

        public static IReadOnlyList<PersonModel> All => new List<PersonModel>
        {
            Johnson, Mendel
        };
    }
}