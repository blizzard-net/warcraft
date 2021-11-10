namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi;

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
        IAchievementApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<AchievementCategory> result = await warcraftClient.GetAchievementCategoryAsync(81, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/achievement-category/81?namespace=static-us&locale=en_US");
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
        IAchievementApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<Achievement> result = await warcraftClient.GetAchievementAsync(6, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/achievement/6?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetAchievementMediaAsync_Gets_AchievementMedia()
    {
        IAchievementApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<AchievementMedia> result = await warcraftClient.GetAchievementMediaAsync(6, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/media/achievement/6?namespace=static-us&locale=en_US");
    }
}
