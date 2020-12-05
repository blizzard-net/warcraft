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

        [ResilientFact]
        public async Task When_Getting_A_Tech_Talent_Tree_By_Id_Then_Successful_Result_With_Expected_Content_Is_Returned()
        {
            ITechTalentApi client = ClientFactory.BuildClient();

            RequestResult<TechTalentTree> result = await client.GetTechTalentTreeAsync(317, "static-us");

            await result.Should().BeSuccessfulRequest()
                .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/tech-talent-tree/317?namespace=static-us&locale=en_US");
        }

        [ResilientFact]
        public async Task When_Getting_The_Tech_Talent_Index_Then_Successful_Result_With_Expected_Content_Is_Returned()
        {
            ITechTalentApi client = ClientFactory.BuildClient();

            RequestResult<TechTalentsIndex> result = await client.GetTechTalentsIndexAsync("static-us");

            await result.Should().BeSuccessfulRequest()
                .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/tech-talent/index?namespace=static-us&locale=en_US");
        }

        [ResilientFact]
        public async Task When_Getting_A_Tech_Talent_By_Id_Then_Successful_Result_With_Expected_Content_Is_Returned()
        {
            ITechTalentApi client = ClientFactory.BuildClient();

            RequestResult<TechTalent> result = await client.GetTechTalentAsync(812, "static-us");

            await result.Should().BeSuccessfulRequest()
                .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/tech-talent/812?namespace=static-us&locale=en_US");
        }
    }
}
