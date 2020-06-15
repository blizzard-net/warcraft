using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests
{
    public class WarcraftClientTestsMountApi
    {
        [Fact]
        public async void GetMountsIndexAsync_Gets_MountsIndex()
        {
            IWarcraftClientMountApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/mount/index?namespace=static-us&locale=en_US",
                responseContent: Resources.MountsIndexResponse);

            RequestResult<MountsIndex> result = await warcraftClient.GetMountsIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetMountAsync_Gets_Mount()
        {
            IWarcraftClientMountApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/mount/6?namespace=static-us&locale=en_US",
                responseContent: Resources.MountResponse);

            RequestResult<Mount> result = await warcraftClient.GetMountAsync(6, "static-us");
            Assert.NotNull(result.Value);
        }
    }
}