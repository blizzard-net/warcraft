using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class CreatureApiTests
    {
        [ResilientFact]
        public async void GetCreatureFamiliesIndexAsync_Gets_CreatureFamiliesIndex()
        {
            ICreatureApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<CreatureFamiliesIndex> result = await warcraftClient.GetCreatureFamiliesIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetCreatureFamilyAsync_Gets_CreatureFamily()
        {
            ICreatureApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<CreatureFamily> result = await warcraftClient.GetCreatureFamilyAsync(1, "static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetCreatureTypesIndexAsync_Gets_CreatureTypesIndex()
        {
            ICreatureApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<CreatureTypesIndex> result = await warcraftClient.GetCreatureTypesIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetCreatureTypeAsync_Gets_CreatureType()
        {
            ICreatureApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<CreatureType> result = await warcraftClient.GetCreatureTypeAsync(1, "static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetCreatureAsync_Gets_Creature()
        {
            ICreatureApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<Creature> result = await warcraftClient.GetCreatureAsync(42722, "static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetCreatureDisplayMediaAsync_Gets_CreatureDisplayMedia()
        {
            ICreatureApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<CreatureDisplayMedia> result = await warcraftClient.GetCreatureDisplayMediaAsync(30221, "static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetCreatureFamilyMediaAsync_Gets_CreatureFamilyMedia()
        {
            ICreatureApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<CreatureFamilyMedia> result = await warcraftClient.GetCreatureFamilyMediaAsync(1, "static-us");
            Assert.NotNull(result.Value);
        }
    }
}
