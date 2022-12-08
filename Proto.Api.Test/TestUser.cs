using FluentAssertions;
using Proto.App.Models;

namespace Proto.Api.Test
{
    public class TestUser
    {
        [Fact]
        public void TestUserFullName()
        {
            User model = new()
            {
                FirstName = "Dill",
                LastName = "Doe"
            };
            var fullname = model.FullName;

            fullname.Should().Be("Dill Doe");
        }
    }
}