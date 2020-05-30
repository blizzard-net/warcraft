using ArgentPonyWarcraftClient.GameData;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests
{
    public class WarcraftClientTestsItemApi
    {
        [Fact]
        public async void GetItemAsync_Gets_Item()
        {
            IWarcraftClientItemApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/item/19019?namespace=static-us&locale=en_US",
                responseContent: Resources.ItemGameDataResponse);

            RequestResult<Item> result = await warcraftClient.GetItemAsync(19019, "static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetItemMediaAsync_Gets_Item()
        {
            IWarcraftClientItemApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/media/item/19019?namespace=static-us&locale=en_US",
                responseContent: Resources.ItemMediaResponse);

            RequestResult<ItemMedia> result = await warcraftClient.GetItemMediaAsync(19019, "static-us");
            Assert.NotNull(result.Value);
        }
    }
}
