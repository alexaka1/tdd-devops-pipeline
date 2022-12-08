using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;

namespace Proto.Int.Test
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1Async()
        {
            await using var application = new WebApplicationFactory<Program>();
            using var client = application.CreateClient();
            var response = await client.GetAsync("/api/user");
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}