using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Integration.Tests.TestUtilities;
using ArgentPonyWarcraftClient.Tests.Assertions;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class TechTalentApiTests
    {
        [ResilientFact]
        public async Task When_Getting_The_Tech_Talent_Tree_Index_Then_Successful_Result_With_Expected_Content_Is_Returned()
        {
            ITechTalentApi client = ClientFactory.BuildClient();

            RequestResult<TechTalentTreesIndex> result = await client.GetTechTalentTreeIndexAsync("static-us");

            await result.Should().BeSuccessfulRequest()
                .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/tech-talent-tree/index?namespace=static-us&locale=en_US");
        }
    }
}
