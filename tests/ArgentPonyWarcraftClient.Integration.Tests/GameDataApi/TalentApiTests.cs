using System.Threading.Tasks;
using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class TalentApiTests
    {
        [ResilientFact]
        public async Task GetTalentsIndexAsync_Gets_TalentsIndex()
        {
            ITalentApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<TalentsIndex> result = await warcraftClient.GetTalentsIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetTalentAsync_Gets_Talent()
        {
            ITalentApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<Talent> result = await warcraftClient.GetTalentAsync(23106, "static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetPvpTalentsIndexAsync_Gets_PvpTalentsIndex()
        {
            ITalentApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<PvpTalentsIndex> result = await warcraftClient.GetPvpTalentsIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetPvpTalentAsync_Gets_PvpTalent()
        {
            ITalentApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<PvpTalent> result = await warcraftClient.GetPvpTalentAsync(11, "static-us");
            Assert.NotNull(result.Value);
        }
    }
}
