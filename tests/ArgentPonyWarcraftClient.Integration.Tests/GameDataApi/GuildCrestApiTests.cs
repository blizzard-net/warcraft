using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class GuildCrestApiTests
    {
        [ResilientFact]
        public async void GetGuildCrestComponentsIndexAsync_Gets_GuildCrestComponentsIndex()
        {
            IGuildCrestApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<GuildCrestComponentsIndex> result = await warcraftClient.GetGuildCrestComponentsIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetGuildCrestBorderMediaAsync_Gets_GuildCrestBorderMedia()
        {
            IGuildCrestApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<GuildCrestBorderMedia> result = await warcraftClient.GetGuildCrestBorderMediaAsync(0, "static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetGuildCrestEmblemMediaAsync_Gets_GuildCrestEmblemMedia()
        {
            IGuildCrestApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<GuildCrestEmblemMedia> result = await warcraftClient.GetGuildCrestEmblemMediaAsync(0, "static-us");
            Assert.NotNull(result.Value);
        }
    }
}
