using System.Threading.Tasks;
using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class ModifiedCraftingApiTests
    {
        [ResilientFact]
        public async Task GetModifiedCraftingIndexAsync_Gets_ModifiedCraftingIndex()
        {
            IModifiedCraftingApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<ModifiedCraftingIndex> result = await warcraftClient.GetModifiedCraftingIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetModifiedCraftingCategoryIndexAsync_Gets_ModifiedCraftingCategoryIndex()
        {
            IModifiedCraftingApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<ModifiedCraftingCategoryIndex> result = await warcraftClient.GetModifiedCraftingCategoryIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetModifiedCraftingCategoryAsync_Gets_ModifiedCraftingCategory()
        {
            IModifiedCraftingApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<ModifiedCraftingCategory> result = await warcraftClient.GetModifiedCraftingCategoryAsync(1, "static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetModifiedCraftingReagentSlotTypeIndexAsync_Gets_ModifiedCraftingReagentSlotTypeIndex()
        {
            IModifiedCraftingApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<ModifiedCraftingReagentSlotTypeIndex> result = await warcraftClient.GetModifiedCraftingReagentSlotTypeIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetModifiedCraftingReagentSlotTypeAsync_Gets_ModifiedCraftingReagentSlotType()
        {
            IModifiedCraftingApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<ModifiedCraftingReagentSlotType> result = await warcraftClient.GetModifiedCraftingReagentSlotTypeAsync(16, "static-us");
            Assert.NotNull(result.Value);
        }
    }
}
