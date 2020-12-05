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

        [Fact]
        public async Task When_Getting_The_Tech_Talent_Index_Then_Successful_Result_With_Expected_Content_Is_Returned()
        {
            ITechTalentApi client = ClientFactory.BuildMockClient(
                "https://us.api.blizzard.com/data/wow/tech-talent/index?namespace=static-us&locale=en_US",
                Resources.TechTalentsIndexResponse
            );

            RequestResult<TechTalentsIndex> result = await client.GetTechTalentsIndexAsync("static-us");

            result.Should().BeSuccessfulRequest()
                .BeEquivalentToJson(Resources.TechTalentsIndexResponse);
        }

        [Fact]
        public async Task When_Getting_A_Tech_Talent_By_Id_Then_Successful_Result_With_Expected_Content_Is_Returned()
        {
            ITechTalentApi client = ClientFactory.BuildMockClient(
                "https://us.api.blizzard.com/data/wow/tech-talent/812?namespace=static-us&locale=en_US",
                Resources.TechTalentResponse);

            RequestResult<TechTalent> result = await client.GetTechTalentAsync(812, "static-us");

            result.Should().BeSuccessfulRequest()
                .BeEquivalentToJson(Resources.TechTalentResponse);
        }

        [Fact]
        public async Task When_Getting_Tech_Talent_Media_By_Id_Then_Successful_Result_With_Expected_Content_Is_Returned()
        {
            ITechTalentApi client = ClientFactory.BuildMockClient(
                "https://us.api.blizzard.com/data/wow/media/tech-talent/1006?namespace=static-us&locale=en_US",
                Resources.TechTalentMediaResponse
            );

            RequestResult<TechTalentMedia> result = await client.GetTechTalentMediaAsync(1006, "static-us");

            result.Should().BeSuccessfulRequest()
                .BeEquivalentToJson(Resources.TechTalentMediaResponse);
        }
    }
}
