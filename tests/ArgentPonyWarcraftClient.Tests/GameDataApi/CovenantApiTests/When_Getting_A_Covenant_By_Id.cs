using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.GameDataApi.CovenantApiTests
{
    public class When_Getting_A_Covenant_By_Id
    {
        [Fact]
        public async Task Then_Successful_Result_With_Expected_Content_Is_Returned()
        {
            ICovenantApi client = ClientFactory.BuildMockClient(
                "https://us.api.blizzard.com/data/wow/covenant/2?namespace=static-us&locale=en_US",
                Resources.CovenantResponse
            );

            RequestResult<Covenant> result = await client.GetCovenantAsync(2, "static-us");

            Assert.NotNull(result);
            Assert.True(result.Success);
            Assert.Null(result.Error);
            Assert.NotNull(result.Value);
            // TODO: Validate result content
        }
    }
}
