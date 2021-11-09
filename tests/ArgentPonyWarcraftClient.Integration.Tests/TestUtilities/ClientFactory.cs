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

    public static RawBlizzardClient BuildRawBlizzardClient()
    {
        ClientCredentials credentials = ClientCredentialsSource.GetCredentials();

        return new RawBlizzardClient(credentials);
    }
}
