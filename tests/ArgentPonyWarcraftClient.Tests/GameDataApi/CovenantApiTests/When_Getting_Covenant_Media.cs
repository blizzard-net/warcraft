using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.GameDataApi.CovenantApiTests
{
    public class When_Getting_Covenant_Media
    {
        [Fact]
        public async Task Then_Successful_Result_With_Expected_Content_Is_Returned()
        {
            ICovenantApi client = ClientFactory.BuildMockClient(
                "https://us.api.blizzard.com/data/wow/media/covenant/2?namespace=static-us&locale=en_US",
                Resources.CovenantMediaResponse
            );

            RequestResult<CovenantMedia> result = await client.GetCovenantMediaAsync(2, "static-us");

            Assert.NotNull(result);
            Assert.True(result.Success);
            Assert.Null(result.Error);
            Assert.NotNull(result.Value);
            // TODO: Assert object content matches
        }
    }
}
