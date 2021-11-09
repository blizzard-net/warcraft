namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi;

public class ModifiedCraftingApiTests
{
    [ResilientFact]
    public async Task GetModifiedCraftingIndexAsync_Gets_ModifiedCraftingIndex()
    {
        IModifiedCraftingApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<ModifiedCraftingIndex> result = await warcraftClient.GetModifiedCraftingIndexAsync("static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/modified-crafting/index?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetModifiedCraftingCategoryIndexAsync_Gets_ModifiedCraftingCategoryIndex()
    {
        IModifiedCraftingApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<ModifiedCraftingCategoryIndex> result = await warcraftClient.GetModifiedCraftingCategoryIndexAsync("static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/modified-crafting/category/index?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetModifiedCraftingCategoryAsync_Gets_ModifiedCraftingCategory()
    {
        IModifiedCraftingApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<ModifiedCraftingCategory> result = await warcraftClient.GetModifiedCraftingCategoryAsync(1, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/modified-crafting/category/1?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetModifiedCraftingReagentSlotTypeIndexAsync_Gets_ModifiedCraftingReagentSlotTypeIndex()
    {
        IModifiedCraftingApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<ModifiedCraftingReagentSlotTypeIndex> result = await warcraftClient.GetModifiedCraftingReagentSlotTypeIndexAsync("static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/modified-crafting/reagent-slot-type/index?namespace=static-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetModifiedCraftingReagentSlotTypeAsync_Gets_ModifiedCraftingReagentSlotType()
    {
        IModifiedCraftingApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<ModifiedCraftingReagentSlotType> result = await warcraftClient.GetModifiedCraftingReagentSlotTypeAsync(16, "static-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/modified-crafting/reagent-slot-type/16?namespace=static-us&locale=en_US");
    }
}
