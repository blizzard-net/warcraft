using System.Net;
using RichardSzalay.MockHttp;

namespace ArgentPonyWarcraftClient.Tests;

internal static class ClientFactory
{
    public static IWarcraftClient BuildMockClient(string requestUri, string responseContent)
    {
        var mockHttp = new MockHttpMessageHandler();

        mockHttp
            .When("https://oauth.battle.net/oauth/token")
            .Respond(
                mediaType: "application/json",
                content: @"{""access_token"": ""ACCESS-TOKEN"", ""token_type"": ""bearer"", ""expires_in"": 86399, ""scope"": ""example.scope""}");

        mockHttp
            .When(requestUri)
            .Respond(mediaType: "application/json", content: responseContent);

        return new WarcraftClient(
            clientId: "clientIdHere",
            clientSecret: "clientSecretHere",
            region: Region.US,
            locale: Locale.en_US,
            client: mockHttp.ToHttpClient());
    }

    public static IWarcraftClient BuildMockClient(string requestUri, string responseContent, HttpStatusCode statusCode)
    {
        var mockHttp = new MockHttpMessageHandler();

        mockHttp
            .When("https://oauth.battle.net/oauth/token")
            .Respond(
                mediaType: "application/json",
                content: @"{""access_token"": ""ACCESS-TOKEN"", ""token_type"": ""bearer"", ""expires_in"": 86399, ""scope"": ""example.scope""}");

        mockHttp
            .When(requestUri)
            .Respond(
                statusCode: statusCode,
                mediaType: "application/json",
                content: responseContent);

        return new WarcraftClient(
            clientId: "clientIdHere",
            clientSecret: "clientSecretHere",
            region: Region.US,
            locale: Locale.en_US,
            client: mockHttp.ToHttpClient());
    }
}
