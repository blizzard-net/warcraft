using System.Net.Http.Headers;

namespace ArgentPonyWarcraftClient.Integration.Tests;

internal static class ClientFactory
{
    public static IWarcraftClient BuildClient()
    {
        ClientCredentials credentials = ClientCredentialsSource.GetCredentials();

        return new WarcraftClient(
            clientId: credentials.ClientId,
            clientSecret: credentials.ClientSecret,
            region: Region.US,
            locale: Locale.en_US);
    }

    public static IWarcraftClient BuildClient(TimeSpan timeout)
    {
        ClientCredentials credentials = ClientCredentialsSource.GetCredentials();

        var client = new HttpClient();
        client.Timeout = timeout;
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        return new WarcraftClient(
            clientId: credentials.ClientId,
            clientSecret: credentials.ClientSecret,
            region: Region.US,
            locale: Locale.en_US,
            client: client);
    }

    public static RawBlizzardClient BuildRawBlizzardClient()
    {
        ClientCredentials credentials = ClientCredentialsSource.GetCredentials();

        return new RawBlizzardClient(credentials);
    }
}
