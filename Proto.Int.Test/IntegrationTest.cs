using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;

namespace Proto.Int.Test
{
    public class IntegrationTest
    {

        [Fact]
        public async Task TestGetUsers()
        {
            await using var application = new WebApplicationFactory<Program>();
            using var client = application.CreateClient();
            var response = await client.GetAsync("/api/user");
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
        [Fact]
        public async Task TestGetUser()
        {
            await using var application = new WebApplicationFactory<Program>();
            using var client = application.CreateClient();
            var response = await client.GetAsync("/api/user/1");
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}