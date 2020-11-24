using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.GameDataApi.CovenantApiTests
{
    public class When_Getting_Conduits_Index
    {
        [Fact]
        public async void Then_Successful_Result_With_Expected_Content_Is_Returned()
        {
            ICovenantApi client = ClientFactory.BuildMockClient(
                "https://us.api.blizzard.com/data/wow/covenant/conduit/index?namespace=static-us&locale=en_US",
                Resources.ConduitsIndexResponse
            );

            RequestResult<ConduitsIndex> result = await client.GetConduitsIndexAsync("static-us");

            Assert.NotNull(result);
            Assert.True(result.Success);
            Assert.Null(result.Error);
            Assert.NotNull(result.Value);
            // TODO: Assert object content matches
        }
    }
}
