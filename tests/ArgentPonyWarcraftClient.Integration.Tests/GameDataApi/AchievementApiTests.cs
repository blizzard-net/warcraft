using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Integration.Tests.TestUtilities;
using ArgentPonyWarcraftClient.Tests.Assertions;
using FluentAssertions;
using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class AchievementApiTests
    {
        [ResilientFact]
        public async Task GetAchievementCategoriesIndexAsync_Gets_AchievementCategoriesIndex()
        {
            IAchievementApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<AchievementCategoriesIndex> result = await warcraftClient.GetAchievementCategoriesIndexAsync("static-us");

            await result.Should().BeSuccessfulRequest()
                .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/achievement-category/index?namespace=static-us&locale=en_US");
        }

        [ResilientFact]
        public async Task GetAchievementCategoryAsync_Gets_AchievementCategory()
        {
            const int achievementCategoryId = 81;

            IAchievementApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<AchievementCategory> result = await warcraftClient.GetAchievementCategoryAsync(achievementCategoryId, "static-us");

            await result.Should().BeSuccessfulRequest()
                .BeEquivalentToBlizzardResponseAsync($"https://us.api.blizzard.com/data/wow/achievement-category/{achievementCategoryId}?namespace=static-us&locale=en_US");
        }

        [ResilientFact]
        public async Task GetAchievementsIndexAsync_Gets_AchievementsIndex()
        {
            IAchievementApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<AchievementsIndex> result = await warcraftClient.GetAchievementsIndexAsync("static-us");

            await result.Should().BeSuccessfulRequest()
                .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/achievement/index?namespace=static-us&locale=en_US");
        }

        [ResilientFact]
        public async Task GetAchievementAsync_Gets_Achievement()
        {
            const int achievementId = 6;

            IAchievementApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<Achievement> result = await warcraftClient.GetAchievementAsync(achievementId, "static-us");

            await result.Should().BeSuccessfulRequest()
                .BeEquivalentToBlizzardResponseAsync($"https://us.api.blizzard.com/data/wow/achievement/{achievementId}?namespace=static-us&locale=en_US");
        }

        [ResilientFact]
        public async Task GetAchievementMediaAsync_Gets_AchievementMedia()
        {
            const int achievementId = 6;

            IAchievementApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<AchievementMedia> result = await warcraftClient.GetAchievementMediaAsync(achievementId, "static-us");

            await result.Should().BeSuccessfulRequest()
                .BeEquivalentToBlizzardResponseAsync($"https://us.api.blizzard.com/data/wow/media/achievement/{achievementId}?namespace=static-us&locale=en_US");
        }
    }
}
