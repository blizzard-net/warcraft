using System.Threading.Tasks;
using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class ProfessionApiTests
    {
        [ResilientFact]
        public async Task GetProfessionsIndexAsync_Gets_ProfessionsIndex()
        {
            IProfessionApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<ProfessionsIndex> result = await warcraftClient.GetProfessionsIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetProfessionAsync_Gets_Profession()
        {
            IProfessionApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<Profession> result = await warcraftClient.GetProfessionAsync(164, "static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetProfessionMediaAsync_Gets_ProfessionMedia()
        {
            IProfessionApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<ProfessionMedia> result = await warcraftClient.GetProfessionMediaAsync(164, "static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetSkillTierAsync_Gets_SkillTier()
        {
            IProfessionApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<SkillTier> result = await warcraftClient.GetSkillTierAsync(164, 2477, "static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetRecipeAsync_Gets_Recipe()
        {
            IProfessionApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<Recipe> result = await warcraftClient.GetRecipeAsync(1631, "static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetRecipeMediaAsync_Gets_RecipeMedia()
        {
            IProfessionApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<RecipeMedia> result = await warcraftClient.GetRecipeMediaAsync(1631, "static-us");
            Assert.NotNull(result.Value);
        }
    }
}
