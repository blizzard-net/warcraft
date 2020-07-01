using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.GameDataApi
{
    public class SpellApiTests
    {
        [Fact]
        public async void GetSpellAsync_Gets_Spell()
        {
            ISpellApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/spell/196607?namespace=static-us&locale=en_US",
                responseContent: Resources.SpellResponse);

            RequestResult<Spell> result = await warcraftClient.GetSpellAsync(196607, "static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetSpellMediaAsync_Gets_SpellMedia()
        {
            ISpellApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/media/spell/196607?namespace=static-us&locale=en_US",
                responseContent: Resources.SpellMediaResponse);

            RequestResult<SpellMedia> result = await warcraftClient.GetSpellMediaAsync(196607, "static-us");
            Assert.NotNull(result.Value);
        }
    }
}
