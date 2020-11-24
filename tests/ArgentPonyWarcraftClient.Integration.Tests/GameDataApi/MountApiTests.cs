using System.Threading.Tasks;
using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.GameDataApi
{
    public class MountApiTests
    {
        [ResilientFact]
        public async Task GetMountsIndexAsync_Gets_MountsIndex()
        {
            IMountApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<MountsIndex> result = await warcraftClient.GetMountsIndexAsync("static-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async Task GetMountAsync_Gets_Mount()
        {
            IMountApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<Mount> result = await warcraftClient.GetMountAsync(6, "static-us");
            Assert.NotNull(result.Value);
        }
    }
}
