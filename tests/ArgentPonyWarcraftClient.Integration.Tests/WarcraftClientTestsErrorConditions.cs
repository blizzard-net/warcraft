using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests;

public class WarcraftClientTestsErrorConditions
{
    [ResilientFact]
    public async Task InvalidIdProducesNotFoundError()
    {
        IWarcraftClient warcraftClient = ClientFactory.BuildClient();

        RequestResult<Item> result = await warcraftClient.GetItemAsync(99999991, "static-us");
        Assert.NotNull(result.Error);
        Assert.Equal(404, result.Error.Code);
        Assert.False(result.Success);
        Assert.Null(result.Value);
    }

    [ResilientFact]
    public async Task InvalidTokenThrowsHttpRequestException()
    {
        IWarcraftClient warcraftClient = ClientFactory.BuildClient();

        HttpRequestException ex = await Assert.ThrowsAsync<HttpRequestException>(
            () => warcraftClient.GetAccountCollectionsIndexAsync("INVALID-ACCESS-TOKEN-FOR-TEST", "profile-us"));

        Assert.NotNull(ex);
    }
}
