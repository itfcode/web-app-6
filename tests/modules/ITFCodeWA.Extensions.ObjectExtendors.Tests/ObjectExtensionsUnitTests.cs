using ITFCodeWA.Extensions.ObjectExtendors;

namespace ItfCodeWA.Extensions.ObjectExtendors.Tests
{
    public class ObjectExtensionsUnitTests
    {
        private readonly string name = "Adam";
        private readonly string email = "adam.profi@gmail.com";
        private readonly DateTime dateOfBirth = DateTime.Now.AddYears(-30);

        [Fact]
        public void Set_Test()
        {
            var user = new User();

            user.Set(nameof(User.Name), name);
            user.Set(nameof(User.Email), email);
            user.Set(nameof(User.DateOfBirth), dateOfBirth);

            Assert.Equal(name, user.Name);
            Assert.Equal(email, user.Email);
            Assert.Equal(dateOfBirth, user.DateOfBirth);
        }

        [Fact]
        public void Exec_Test()
        {
            var user = new User {};

            user.Exec(x => x.Name = name)
                .Exec(x => x.Email = email)
                .Exec(x => x.DateOfBirth = dateOfBirth);

            Assert.Equal(name, user.Name);
            Assert.Equal(email, user.Email);
            Assert.Equal(dateOfBirth, user.DateOfBirth);
        }

        [Fact]
        public void TryGet_Test()
        {
            var user = new User { Name = name, Email = email };

            Assert.Equal(name, user.GetTry(x => x.Name, string.Empty));
            Assert.Equal(email, user.GetTry(x => x.Email, string.Empty));
            Assert.Equal(dateOfBirth, user.GetTry(x => x.DateOfBirth, dateOfBirth));
        }
    }

    public class UserBase
    {
        public string Name { get; set; } = string.Empty;
    }

    public class User : UserBase
    {
        public string Email { get; set; } = string.Empty;

        public DateTime? DateOfBirth { get; set; }
    }
}