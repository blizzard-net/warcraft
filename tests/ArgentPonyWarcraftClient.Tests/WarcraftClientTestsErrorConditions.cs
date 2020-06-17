using System;
using System.Net;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests
{
    public class WarcraftClientTestsErrorConditions
    {
        [Fact]
        public async void InvalidIdProducesNotFoundError()
        {
            IWarcraftClient warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/item/99999991?namespace=static-us&locale=en_US",
                responseContent: Resources.Item404ErrorResponse,
                statusCode: HttpStatusCode.NotFound);

            RequestResult<Item> result = await warcraftClient.GetItemAsync(99999991, "static-us");
            Assert.NotNull(result.Error);
            Assert.Equal("404", result.Error.Code);
            Assert.False(result.Success);
            Assert.Null(result.Value);
        }

        [Fact]
        public async void InvalidJsonProducesError()
        {
            IWarcraftClient warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/journal-encounter/89?namespace=static-us&locale=en_US",
                responseContent: Resources.JournalEncounterResponseTruncated);

            RequestResult<Encounter> result = await warcraftClient.GetJournalEncounterAsync(89, "static-us");
            Assert.NotNull(result.Error);
            Assert.Equal("Newtonsoft.Json.JsonReaderException", result.Error.Type);
            Assert.Equal("Unterminated string. Expected delimiter: \". Path 'description', line 9, position 49.", result.Error.Detail);
            Assert.False(result.Success);
            Assert.Null(result.Value);
        }

        [Fact]
        public async void ProducesForbiddenError()
        {
            IWarcraftClient warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/data/wow/item/19019?namespace=static-us&locale=en_US",
                responseContent: Resources.AccountInactive403ForbiddenResponse,
                statusCode: HttpStatusCode.Forbidden);

            RequestResult<Item> result = await warcraftClient.GetItemAsync(19019, "static-us");
            Assert.NotNull(result.Error);
            Assert.Equal("403", result.Error.Code);
            Assert.False(result.Success);
            Assert.Null(result.Value);
        }

        [Fact]
        public void Throws_ArgumentException_Invaild_Region_Locale()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                IWarcraftClient client = new WarcraftClient("clientIdHere", "clientSecretHere", Region.Korea, Locale.fr_FR);
            });
        }
    }
}
