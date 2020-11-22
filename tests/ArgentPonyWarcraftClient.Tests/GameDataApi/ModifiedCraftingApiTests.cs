using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.GameDataApi
{
    public class ModifiedCraftingApiTests
    {
        [Fact]
        public async void GetModifiedCraftingIndexAsync_Gets_ModifiedCraftingIndex()
        {
            IModifiedCraftingApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/modified-crafting/index?namespace=static-us&locale=en_US",
                responseContent: Resources.ModifiedCraftingIndexResponse);

            RequestResult<ModifiedCraftingIndex> result = await warcraftClient.GetModifiedCraftingIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetModifiedCraftingCategoryIndexAsync_Gets_ModifiedCraftingCategoryIndex()
        {
            IModifiedCraftingApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/modified-crafting/category/index?namespace=static-us&locale=en_US",
                responseContent: Resources.ModifiedCraftingCategoryIndexResponse);

            RequestResult<ModifiedCraftingCategoryIndex> result = await warcraftClient.GetModifiedCraftingCategoryIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetModifiedCraftingCategoryAsync_Gets_ModifiedCraftingCategory()
        {
            IModifiedCraftingApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/modified-crafting/category/1?namespace=static-us&locale=en_US",
                responseContent: Resources.ModifiedCraftingCategoryResponse);

            RequestResult<ModifiedCraftingCategory> result = await warcraftClient.GetModifiedCraftingCategoryAsync(1, "static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetModifiedCraftingReagentSlotTypeIndexAsync_Gets_ModifiedCraftingReagentSlotTypeIndex()
        {
            IModifiedCraftingApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/modified-crafting/reagent-slot-type/index?namespace=static-us&locale=en_US",
                responseContent: Resources.ModifiedCraftingReagentSlotTypeIndexResponse);

            RequestResult<ModifiedCraftingReagentSlotTypeIndex> result = await warcraftClient.GetModifiedCraftingReagentSlotTypeIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetModifiedCraftingReagentSlotTypeAsync_Gets_ModifiedCraftingReagentSlotType()
        {
            IModifiedCraftingApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/modified-crafting/reagent-slot-type/16?namespace=static-us&locale=en_US",
                responseContent: Resources.ModifiedCraftingReagentSlotTypeResponse);

            RequestResult<ModifiedCraftingReagentSlotType> result = await warcraftClient.GetModifiedCraftingReagentSlotTypeAsync(16, "static-us");
            Assert.NotNull(result.Value);
        }
    }
}
