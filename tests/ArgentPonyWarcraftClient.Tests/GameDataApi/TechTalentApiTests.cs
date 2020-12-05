using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Tests.Assertions;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.GameDataApi
{
    public class TechTalentApiTests
    {
        [Fact]
        public async Task When_Getting_The_Tech_Talent_Tree_Index_Then_Successful_Result_With_Expected_Content_Is_Returned()
        {
            ITechTalentApi client = ClientFactory.BuildMockClient(
                "https://us.api.blizzard.com/data/wow/tech-talent-tree/index?namespace=static-us&locale=en_US",
                Resources.TechTalentTreeIndexResponse
            );

            RequestResult<TechTalentTreesIndex> result = await client.GetTechTalentTreeIndexAsync("static-us");

            result.Should().BeSuccessfulRequest()
                .BeEquivalentToJson(Resources.TechTalentTreeIndexResponse);
        }

        [Fact]
        public async Task When_Getting_A_Tech_Talent_Tree_By_Id_Then_Successful_Result_With_Expected_Content_Is_Returned()
        {
            ITechTalentApi client = ClientFactory.BuildMockClient(
                "https://us.api.blizzard.com/data/wow/tech-talent-tree/317?namespace=static-us&locale=en_US",
                Resources.TechTalentTreeResponse
            );

            RequestResult<TechTalentTree> result = await client.GetTechTalentTreeAsync(317, "static-us");

            result.Should().BeSuccessfulRequest()
                .BeEquivalentToJson(Resources.TechTalentTreeResponse);
        }
    }
}
