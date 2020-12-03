using System;
using System.Text.Json;
using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Tests.Properties;
using FluentAssertions;
using Newtonsoft.Json.Linq;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.GameDataApi
{
    public class CovenantApiTests
    {
        [Fact]
        public async Task When_Getting_A_Conduit_By_Id_Then_Successful_Result_With_Expected_Content_Is_Returned()
        {
            ICovenantApi client = ClientFactory.BuildMockClient(
                "https://us.api.blizzard.com/data/wow/covenant/conduit/10?namespace=static-us&locale=en_US",
                Resources.ConduitResponse
            );

            RequestResult<Conduit> result = await client.GetConduitAsync(10, "static-us");

            Assert.NotNull(result);
            Assert.True(result.Success);
            Assert.Null(result.Error);
            Assert.NotNull(result.Value);
            // TODO: Validate result content
        }

        [Fact]
        public async Task When_Getting_A_Covenant_By_Id_Then_Successful_Result_With_Expected_Content_Is_Returned()
        {
            ICovenantApi client = ClientFactory.BuildMockClient(
                "https://us.api.blizzard.com/data/wow/covenant/2?namespace=static-us&locale=en_US",
                Resources.CovenantResponse
            );

            RequestResult<Covenant> result = await client.GetCovenantAsync(2, "static-us");

            Assert.NotNull(result);
            Assert.True(result.Success);
            Assert.Null(result.Error);
            Assert.NotNull(result.Value);
            // TODO: Validate result content
        }

        [Fact]
        public async Task When_Getting_A_Soulbind_By_Id_Then_Successful_Result_With_Expected_Content_Is_Returned()
        {
            ICovenantApi client = ClientFactory.BuildMockClient(
                "https://us.api.blizzard.com/data/wow/covenant/soulbind/2?namespace=static-us&locale=en_US",
                Resources.SoulbindResponse
            );

            RequestResult<Soulbind> result = await client.GetSoulbindAsync(2, "static-us");

            Assert.NotNull(result);
            Assert.True(result.Success);
            Assert.Null(result.Error);
            Assert.NotNull(result.Value);
            // TODO: Assert object content matches
        }

        [Fact]
        public async Task When_Getting_Conduits_Index_Then_Successful_Result_With_Expected_Content_Is_Returned()
        {
            ICovenantApi client = ClientFactory.BuildMockClient(
                "https://us.api.blizzard.com/data/wow/covenant/conduit/index?namespace=static-us&locale=en_US",
                Resources.ConduitsIndexResponse
            );

            RequestResult<ConduitsIndex> result = await client.GetConduitsIndexAsync("static-us");

            Assert.NotNull(result);
            Assert.True(result.Success);
            Assert.Null(result.Error);
            Assert.NotNull(result.Value);
            // TODO: Assert object content matches
        }

        [Fact]
        public async Task When_Getting_Covenant_Media_Then_Successful_Result_With_Expected_Content_Is_Returned()
        {
            ICovenantApi client = ClientFactory.BuildMockClient(
                "https://us.api.blizzard.com/data/wow/media/covenant/2?namespace=static-us&locale=en_US",
                Resources.CovenantMediaResponse
            );

            RequestResult<CovenantMedia> result = await client.GetCovenantMediaAsync(2, "static-us");

            Assert.NotNull(result);
            Assert.True(result.Success);
            Assert.Null(result.Error);
            Assert.NotNull(result.Value);
            // TODO: Assert object content matches
        }

        [Fact]
        public async Task When_Getting_Covenants_Index_Then_Successful_Result_With_Expected_Content_Is_Returned()
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

            Assert.NotNull(result);
            Assert.True(result.Success);
            Assert.Null(result.Error);
            Assert.NotNull(result.Value);

            var actualJsonValue = JObject.Parse(JsonSerializer.Serialize(result.Value));
            var expectedJsonValue = JObject.Parse(expectedContent);

            actualJsonValue.Should().BeEquivalentTo(expectedJsonValue);
        }
    }
}
