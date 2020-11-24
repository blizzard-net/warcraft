using System.Threading.Tasks;
using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class SpellApiTests
    {
        [ResilientFact]
        public async Task GetSpellAsync_Gets_Spell()
        {
            ISpellApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<Spell> result = await warcraftClient.GetSpellAsync(196607, "static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetSpellMediaAsync_Gets_SpellMedia()
        {
            ISpellApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<SpellMedia> result = await warcraftClient.GetSpellMediaAsync(196607, "static-us");
            Assert.NotNull(result.Value);
        }
    }
}
