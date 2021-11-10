using System.Net;

namespace ArgentPonyWarcraftClient.Tests;

public class WarcraftClientTestsErrorConditions
{
    [Fact]
    public async Task InvalidIdProducesNotFoundError()
    {
        IWarcraftClient warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/item/99999991?namespace=static-us&locale=en_US",
            responseContent: Resources.Item404ErrorResponse,
            statusCode: HttpStatusCode.NotFound);

        RequestResult<Item> result = await warcraftClient.GetItemAsync(99999991, "static-us");
        Assert.NotNull(result.Error);
        Assert.Equal(404, result.Error.Code);
        Assert.False(result.Success);
        Assert.Null(result.Value);
    }

    [Fact]
    public async Task InvalidJsonProducesError()
    {
        IWarcraftClient warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/journal-encounter/89?namespace=static-us&locale=en_US",
            responseContent: Resources.JournalEncounterResponseTruncated);

        RequestResult<Encounter> result = await warcraftClient.GetJournalEncounterAsync(89, "static-us");
        Assert.NotNull(result.Error);
        Assert.Equal("System.Text.Json.JsonException", result.Error.Type);
        Assert.Equal("Expected end of string, but instead reached end of data. Path: $.description | LineNumber: 8 | BytePositionInLine: 49.", result.Error.Detail);
        Assert.False(result.Success);
        Assert.Null(result.Value);
    }

    [Fact]
    public async Task ProducesForbiddenError()
    {
        IWarcraftClient warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/item/19019?namespace=static-us&locale=en_US",
            responseContent: Resources.AccountInactive403ForbiddenResponse,
            statusCode: HttpStatusCode.Forbidden);

        RequestResult<Item> result = await warcraftClient.GetItemAsync(19019, "static-us");
        Assert.NotNull(result.Error);
        Assert.Equal(403, result.Error.Code);
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
