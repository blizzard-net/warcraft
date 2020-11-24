using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.GameDataApi.CovenantApiTests
{
    public class When_Getting_Covenants_Index
    {
        [Fact]
        public async void When_Getting_Covenants_Index_Then_Successful_Result_With_Expected_Content_Is_Returned()
        {
            ICovenantApi client = ClientFactory.BuildMockClient(
                "https://us.api.blizzard.com/data/wow/covenant/index?namespace=static-us&locale=en_US",
                responseContent: Resources.CovenantsIndexResponse
            );

            RequestResult<CovenantsIndex> result = await client.GetCovenantsIndexAsync("static-us");

            Assert.NotNull(result);
            Assert.True(result.Success);
            Assert.Null(result.Error);
            Assert.NotNull(result.Value);
            // TODO: Assert object content matches
        }
    }
}
