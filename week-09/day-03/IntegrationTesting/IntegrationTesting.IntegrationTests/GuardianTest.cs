using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTesting.IntegrationTests
{
    public class GuardianTests
    {
        private HttpClient client;
        private TestServer server;

        public GuardianTests()
        {
            server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            client = server.CreateClient();
        }

        [Fact]
        public async Task IAmGrootShouldReturnOkStatus()
        {
            var response = await client.GetAsync("guardian/groot?message=huehue");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task IAmGrootShouldNotReturnOkStatus()
        {
            var response = await client.GetAsync("guardian/groot");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task IAmGrootShouldReturnSameValue()
        {
            var response = await client.GetAsync("guardian/groot?message=huehue");
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"received\":\"huehue\",\"translated\":\"I am Groot!\"}", responseJson);
        }

        [Fact]
        public async Task IAmGrootShouldReturnErrorMessage()
        {
            var response = await client.GetAsync("guardian/groot");
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"error\":\"I am Error!\"}", responseJson);
        }
    }
}
