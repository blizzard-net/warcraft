using System;
using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Tests.Assertions;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.GameDataApi
{
    public class CovenantApiTests
    {
        [Fact]
        public Task When_Getting_A_Conduit_By_Id_Then_Successful_Result_With_Expected_Content_Is_Returned()
        {
            return ThenClientReturnsSuccessfulResultWithExpectedContent(
                "https://us.api.blizzard.com/data/wow/covenant/conduit/10?namespace=static-us&locale=en_US",
                Resources.ConduitResponse,
                client => client.GetConduitAsync(10, "static-us")
            );
        }

        [Fact]
        public Task When_Getting_A_Covenant_By_Id_Then_Successful_Result_With_Expected_Content_Is_Returned()
        {
            return ThenClientReturnsSuccessfulResultWithExpectedContent(
                "https://us.api.blizzard.com/data/wow/covenant/2?namespace=static-us&locale=en_US",
                Resources.CovenantResponse,
                client => client.GetCovenantAsync(2, "static-us")
            );
        }

        [Fact]
        public Task When_Getting_A_Soulbind_By_Id_Then_Successful_Result_With_Expected_Content_Is_Returned()
        {
            return ThenClientReturnsSuccessfulResultWithExpectedContent(
                "https://us.api.blizzard.com/data/wow/covenant/soulbind/2?namespace=static-us&locale=en_US",
                Resources.SoulbindResponse,
                client => client.GetSoulbindAsync(2, "static-us")
            );
        }

        [Fact]
        public Task When_Getting_Conduits_Index_Then_Successful_Result_With_Expected_Content_Is_Returned()
        {
            return ThenClientReturnsSuccessfulResultWithExpectedContent(
                "https://us.api.blizzard.com/data/wow/covenant/conduit/index?namespace=static-us&locale=en_US",
                Resources.ConduitsIndexResponse,
                client => client.GetConduitsIndexAsync("static-us")
            );
        }

        [Fact]
        public Task When_Getting_Covenant_Media_Then_Successful_Result_With_Expected_Content_Is_Returned()
        {
            return ThenClientReturnsSuccessfulResultWithExpectedContent(
                "https://us.api.blizzard.com/data/wow/media/covenant/2?namespace=static-us&locale=en_US",
                Resources.CovenantMediaResponse,
                client => client.GetCovenantMediaAsync(2, "static-us")
            );
        }

        [Fact]
        public Task When_Getting_Covenants_Index_Then_Successful_Result_With_Expected_Content_Is_Returned()
        {
            return ThenClientReturnsSuccessfulResultWithExpectedContent(
                "https://us.api.blizzard.com/data/wow/covenant/index?namespace=static-us&locale=en_US",
                Resources.CovenantsIndexResponse,
                client => client.GetCovenantsIndexAsync("static-us")
            );
        }

        [Fact]
        public Task When_Getting_Soulbinds_Index_Then_Successful_Result_With_Expected_Content_Is_Returned()
        {
            return ThenClientReturnsSuccessfulResultWithExpectedContent(
                "https://us.api.blizzard.com/data/wow/covenant/soulbind/index?namespace=static-us&locale=en_US",
                Resources.SoulbindsIndexResponse,
                client => client.GetSoulbindsIndexAsync("static-us")
            );
        }

        private async Task ThenClientReturnsSuccessfulResultWithExpectedContent<T>(
            string expectedRequestUri,
            string expectedContent,
            Func<ICovenantApi, Task<RequestResult<T>>> clientMethodUnderTest)
        {
            ICovenantApi client = ClientFactory.BuildMockClient(
                expectedRequestUri,
                expectedContent
            );

            RequestResult<T> result = await clientMethodUnderTest(client);

            result.Should().BeSuccessfulRequest()
                .BeEquivalentToJson(expectedContent);
        }
    }
}
