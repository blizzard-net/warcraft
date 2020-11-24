using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.GameDataApi.CovenantApiTests
{
    public class When_Getting_Soulbinds_Index
    {
        [Fact]
        public async Task Then_Successful_Result_With_Expected_Content_Is_Returned()
        {
            ICovenantApi client = ClientFactory.BuildMockClient(
                "https://us.api.blizzard.com/data/wow/covenant/soulbind/index?namespace=static-us&locale=en_US",
                Resources.SoulbindsIndexResponse
            );

            RequestResult<SoulbindsIndex> result = await client.GetSoulbindsIndexAsync("static-us");

            Assert.NotNull(result);
            Assert.True(result.Success);
            Assert.Null(result.Error);
            Assert.NotNull(result.Value);
            // TODO: Assert object content matches
        }
    }
}
