using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Integration.Tests.TestUtilities;
using ArgentPonyWarcraftClient.Tests.Assertions;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class ProfessionApiTests
    {
        [ResilientFact]
        public async Task GetProfessionsIndexAsync_Gets_ProfessionsIndex()
        {
            IProfessionApi warcraftClient = ClientFactory.BuildClient();

            RequestResult<ProfessionsIndex> result = await warcraftClient.GetProfessionsIndexAsync("static-us");

            await result.Should().BeSuccessfulRequest()
                .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/profession/index?namespace=static-us&locale=en_US");
        }

        [ResilientFact]
        public async Task GetProfessionAsync_Gets_Profession()
        {
            IProfessionApi warcraftClient = ClientFactory.BuildClient();

            RequestResult<Profession> result = await warcraftClient.GetProfessionAsync(164, "static-us");

            await result.Should().BeSuccessfulRequest()
                .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/profession/164?namespace=static-us&locale=en_US");
        }

        [ResilientFact]
        public async Task GetProfessionMediaAsync_Gets_ProfessionMedia()
        {
            IProfessionApi warcraftClient = ClientFactory.BuildClient();

            RequestResult<ProfessionMedia> result = await warcraftClient.GetProfessionMediaAsync(164, "static-us");

            await result.Should().BeSuccessfulRequest()
                .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/media/profession/164?namespace=static-us&locale=en_US");
        }

        [ResilientFact]
        public async Task GetSkillTierAsync_Gets_SkillTier()
        {
            IProfessionApi warcraftClient = ClientFactory.BuildClient();

            RequestResult<SkillTier> result = await warcraftClient.GetSkillTierAsync(164, 2477, "static-us");

            await result.Should().BeSuccessfulRequest()
                .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/profession/164/skill-tier/2477?namespace=static-us&locale=en_US");
        }

        [ResilientFact]
        public async Task GetRecipeAsync_Gets_Recipe()
        {
            IProfessionApi warcraftClient = ClientFactory.BuildClient();

            RequestResult<Recipe> result = await warcraftClient.GetRecipeAsync(1631, "static-us");

            await result.Should().BeSuccessfulRequest()
                .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/recipe/1631?namespace=static-us&locale=en_US");
        }

        [ResilientFact]
        public async Task GetRecipeMediaAsync_Gets_RecipeMedia()
        {
            IProfessionApi warcraftClient = ClientFactory.BuildClient();

            RequestResult<RecipeMedia> result = await warcraftClient.GetRecipeMediaAsync(1631, "static-us");

            await result.Should().BeSuccessfulRequest()
                .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/media/recipe/1631?namespace=static-us&locale=en_US");
        }
    }
}
