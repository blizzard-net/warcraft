using System.Threading.Tasks;
using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class PlayableRaceApiTests
    {
        [ResilientFact]
        public async Task GetPlayableRacesIndexAsync_Gets_PlayableRacesIndex()
        {
            IPlayableRaceApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<PlayableRacesIndex> result = await warcraftClient.GetPlayableRacesIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetPlayableRaceAsync_Gets_PlayableRace()
        {
            IPlayableRaceApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<PlayableRace> result = await warcraftClient.GetPlayableRaceAsync(2, "static-us");
            Assert.NotNull(result.Value);
        }
    }
}
