using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace ArgentPonyWarcraftClient.Extensions.DependencyInjection.Tests.ServiceCollectionExtensionsTests
{
    public class When_Adding_Warcraft_Clients
    {
        private readonly IServiceCollection _services;

        public When_Adding_Warcraft_Clients()
        {
            _services = new ServiceCollection();

        }

        [Fact]
        public void Then_All_Warcraft_Interfaces_Are_Resolved_To_A_WarcraftClient_Instance()
        {
            Assert.True(false, "TODO");
        }

        [Fact]
        public void Then_WarcraftClient_Is_Created_Provided_Client_Credentials()
        {
            Assert.True(false, "TODO");
        }

        [Fact]
        public void Then_WarcraftClient_Is_Created_With_US_Region_And_en_US_Locale()
        {
            Assert.True(false, "TODO");
        }

        [Fact]
        public void Then_WarcraftClient_Uses_HttpClient_From_Http_Client_Factory()
        {
            Assert.True(false, "TODO");
        }
    }
}
