using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Rest;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace RestTesting
{
    public class RestTests
    {
        private HttpClient client;
        private TestServer server;

        public RestTests()
        {
            server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            client = server.CreateClient();
        }

        [Fact]
        public async Task ShouldReturnDouble()
        {
            var response = await client.GetAsync("/doubling?input=10");
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"received\":10,\"result\":20}", responseJson);
        }

        [Fact]
        public async Task ShouldReturnGreetingMessage()
        {
            var response = await client.GetAsync("/greeter?name=Botond&title=nightmare");
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"welcome_message\":\"Oh, hi there Botond, my dear nightmare!\"}", responseJson);
        }

        [Fact]
        public async Task ShouldReturnKacsa()
        {
            var response = await client.GetAsync("/appenda/kacs");
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"appended\":\"kacsa\"}", responseJson);
        }

        [Fact]
        public async Task ShouldReturnDoUntilSum()
        {
            var response = await client.GetAsync("/dountil/sum");
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{until:suchnumber,result:suchnumber}", responseJson);
        }

        [Fact]
        public async Task ShouldReturnDoUntilFactor()
        {
            var response = await client.GetAsync("/dountil/factor");
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{until:suchnumber,result:suchnumber}", responseJson);
        }
    }
}
