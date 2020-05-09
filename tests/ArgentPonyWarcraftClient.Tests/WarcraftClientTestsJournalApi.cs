using ArgentPonyWarcraftClient.GameData;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests
{
    public class WarcraftClientTestsJournalApi
    {
        [Fact]
        public async void GetJournalExpansionsIndexAsync_Gets_JournalExpansions()
        {
            IWarcraftClientJournalApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/journal-expansion/index?namespace=static-us&locale=en_US",
                responseContent: Resources.JournalExpansionsIndexResponse);

            RequestResult<JournalExpansionsIndex> result = await warcraftClient.GetJournalExpansionsIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetJournalExpansionAsync_Gets_JournalExpansion()
        {
            IWarcraftClientJournalApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/journal-expansion/68?namespace=static-us&locale=en_US",
                responseContent: Resources.JournalExpansionResponse);

            RequestResult<JournalExpansion> result = await warcraftClient.GetJournalExpansionAsync(68, "static-us");
            Assert.NotNull(result.Value);
        }
    }
}
