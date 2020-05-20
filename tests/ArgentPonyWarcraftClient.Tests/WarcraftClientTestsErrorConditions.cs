using ArgentPonyWarcraftClient.Community;
using ArgentPonyWarcraftClient.GameData;
using ArgentPonyWarcraftClient.Tests.Properties;
using System;
using System.Net;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests
{
    public class WarcraftClientTestsErrorConditions
    {
        [Fact]
        public async void ProducesNotFoundError()
        {
            IWarcraftClient warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/wow/zone/99999991?locale=en_US",
                responseContent: Resources.Zone404ErrorResponse,
                statusCode: HttpStatusCode.NotFound);

            RequestResult<Zone> result = await warcraftClient.GetZoneAsync(99999991);
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
                requestUri: "https://us.api.blizzard.com/wow/zone/4131?locale=en_US",
                responseContent: Resources.AccountInactive403ForbiddenResponse,
                statusCode: HttpStatusCode.Forbidden);

            RequestResult<Zone> result = await warcraftClient.GetZoneAsync(4131);
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
