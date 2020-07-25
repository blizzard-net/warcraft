using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class PlayableRaceApiTests
    {
        [ResilientFact]
        public async void GetPlayableRacesIndexAsync_Gets_PlayableRacesIndex()
        {
            IPlayableRaceApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<PlayableRacesIndex> result = await warcraftClient.GetPlayableRacesIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetPlayableRaceAsync_Gets_PlayableRace()
        {
            IPlayableRaceApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<PlayableRace> result = await warcraftClient.GetPlayableRaceAsync(2, "static-us");
            Assert.NotNull(result.Value);
        }
    }
}
