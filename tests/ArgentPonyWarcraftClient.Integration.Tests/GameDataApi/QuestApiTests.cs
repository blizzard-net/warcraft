namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi;

public class QuestApiTests
{
    [ResilientFact]
    public async Task GetQuestsIndexAsync_Gets_QuestsIndex()
    {
        IQuestApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<QuestsIndex> result = await warcraftClient.GetQuestsIndexAsync("static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/quest/index?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetQuestAsync_Gets_Quest()
    {
        IQuestApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<Quest> result = await warcraftClient.GetQuestAsync(2, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/quest/2?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetQuestCategoriesIndexAsync_Gets_QuestCategoriesIndex()
    {
        IQuestApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<QuestCategoriesIndex> result = await warcraftClient.GetQuestCategoriesIndexAsync("static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/quest/category/index?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetQuestCategoryAsync_Gets_QuestCategory()
    {
        IQuestApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<QuestCategory> result = await warcraftClient.GetQuestCategoryAsync(1, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/quest/category/1?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetQuestAreasIndexAsync_Gets_QuestAreasIndex()
    {
        IQuestApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<QuestAreasIndex> result = await warcraftClient.GetQuestAreasIndexAsync("static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/quest/area/index?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetQuestAreaAsync_Gets_QuestArea()
    {
        IQuestApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<QuestArea> result = await warcraftClient.GetQuestAreaAsync(1, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/quest/area/1?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetQuestTypesIndexAsync_Gets_QuestTypesIndex()
    {
        IQuestApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<QuestTypesIndex> result = await warcraftClient.GetQuestTypesIndexAsync("static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/quest/type/index?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetQuestTypeAsync_Gets_QuestType()
    {
        IQuestApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<QuestType> result = await warcraftClient.GetQuestTypeAsync(1, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/quest/type/1?namespace=static-us&locale=en_US");
    }
}
