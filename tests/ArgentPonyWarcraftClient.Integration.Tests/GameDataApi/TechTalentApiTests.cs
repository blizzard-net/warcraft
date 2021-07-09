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

            RequestResult<TechTalentTreesIndex> result = await client.GetTechTalentTreesIndexAsync("static-us");

            await result.Should().BeSuccessfulRequest()
                .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/tech-talent-tree/index?namespace=static-us&locale=en_US");
        }

        [ResilientFact]
        public async Task When_Getting_A_Tech_Talent_Tree_By_Id_Then_Successful_Result_With_Expected_Content_Is_Returned()
        {
            ITechTalentApi client = ClientFactory.BuildClient();

            RequestResult<TechTalentTree> result = await client.GetTechTalentTreeAsync(275, "static-us");

            await result.Should().BeSuccessfulRequest()
                .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/tech-talent-tree/275?namespace=static-us&locale=en_US");
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

            RequestResult<TechTalent> result = await client.GetTechTalentAsync(863, "static-us");

            await result.Should().BeSuccessfulRequest()
                .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/tech-talent/863?namespace=static-us&locale=en_US");
        }

        [ResilientFact]
        public async Task When_Getting_Tech_Talent_Media_By_Id_Then_Successful_Result_With_Expected_Content_Is_Returned()
        {
            ITechTalentApi client = ClientFactory.BuildClient();

            RequestResult<TechTalentMedia> result = await client.GetTechTalentMediaAsync(1612, "static-us");

            await result.Should().BeSuccessfulRequest()
                .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/media/tech-talent/1612?namespace=static-us&locale=en_US");
        }
    }
}
