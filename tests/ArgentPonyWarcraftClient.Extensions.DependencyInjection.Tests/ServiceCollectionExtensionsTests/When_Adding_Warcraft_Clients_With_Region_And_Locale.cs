using System.Net.Http.Headers;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace ArgentPonyWarcraftClient.Extensions.DependencyInjection.Tests.ServiceCollectionExtensionsTests;

public class When_Adding_Warcraft_Clients_With_Region_And_Locale
{
    private readonly IServiceCollection _services;

    public When_Adding_Warcraft_Clients_With_Region_And_Locale()
    {
        _services = new ServiceCollection();
    }

    public static IEnumerable<object[]> LocaleAndRegionPairs
    {
        get
        {
            var locales = Enum.GetValues(typeof(Locale))
                .Cast<Locale>();

            return locales.Select(locale => new object[]
            {
                    new ValidLocaleAndRegionPair(locale)
            });
        }
    }

    public static IEnumerable<object[]> InvalidLocaleAndRegionPairs
    {
        get
        {
            var allLocales = Enum.GetValues(typeof(Locale)).Cast<Locale>().ToList();
            var allRegions = Enum.GetValues(typeof(Region)).Cast<Region>().ToList();

            foreach (var locale in allLocales)
            {
                foreach (var region in allRegions)
                {
                    var validLocaleAndRegion = new ValidLocaleAndRegionPair(locale);

                    if (region == validLocaleAndRegion.Region)
                    {
                        continue;
                    }

                    yield return new object[] { locale, region };
                }
            }
        }
    }

    public static IEnumerable<object[]> ClientInterfacesWithLocaleAndRegionPair
    {
        get
        {
            foreach (var clientInterfaceTestData in new WarcraftClientInterfaceData())
            {
                foreach (var localeAndRegionPair in LocaleAndRegionPairs)
                {
                    yield return clientInterfaceTestData.Concat(localeAndRegionPair).ToArray();
                }
            }
        }
    }

    [Theory]
    [MemberData(nameof(LocaleAndRegionPairs))]
    public void If_Client_Id_Is_Null_Then_ArgumentNullException_Is_Thrown(ValidLocaleAndRegionPair localeAndRegion)
    {
        var exception = Assert.Throws<ArgumentNullException>(() =>
            _services.AddWarcraftClients(null, "fake-client-secret", localeAndRegion.Region, localeAndRegion.Locale)
        );

        Assert.Equal("clientId", exception.ParamName);
    }

    [Theory]
    [MemberData(nameof(LocaleAndRegionPairs))]
    public void If_Client_Secret_Is_Null_Then_ArgumentNullException_Is_Thrown(ValidLocaleAndRegionPair localeAndRegion)
    {
        var exception = Assert.Throws<ArgumentNullException>(() =>
            _services.AddWarcraftClients("fake-client-id", null, localeAndRegion.Region, localeAndRegion.Locale)
        );

        Assert.Equal("clientSecret", exception.ParamName);
    }

    [Theory]
    [MemberData(nameof(InvalidLocaleAndRegionPairs))]
    public void
        If_Locale_And_Region_Are_Not_Compatible_Then_ArgumentException_Is_Thrown_Stating_The_Locale_And_Region_Are_Not_Compatible(
            Locale locale, Region region)
    {
        var exception = Assert.Throws<ArgumentException>(() =>
            _services.AddWarcraftClients("fake-client-id", "fake-client-secret", region, locale)
        );

        Assert.Equal("The locale selected is not supported by the selected region.", exception.Message);
    }

    [Theory]
    [MemberData(nameof(ClientInterfacesWithLocaleAndRegionPair))]
    public void Then_All_Warcraft_Interfaces_Are_Resolved_To_A_WarcraftClient_Instance(
        Type clientInterfaceToResolve, ValidLocaleAndRegionPair localeAndRegion)
    {
        _services.AddWarcraftClients("fake-client-id", "fake-client-secret", localeAndRegion.Region,
            localeAndRegion.Locale);

        IServiceProvider serviceProvider = _services.BuildServiceProvider();

        var client = serviceProvider.GetRequiredService(clientInterfaceToResolve);

        Assert.IsType<WarcraftClient>(client);
    }

    [Theory]
    [MemberData(nameof(LocaleAndRegionPairs))]
    public void Then_WarcraftClient_Is_Created_With_Provided_Client_Credentials_And_Region_And_Locale(
        ValidLocaleAndRegionPair localeAndRegion)
    {
        const string expectedClientId = "the client Id";
        const string expectedClientSecret = "the client secret";

        _services.AddWarcraftClients(expectedClientId, expectedClientSecret, localeAndRegion.Region,
            localeAndRegion.Locale);

        IServiceProvider serviceProvider = _services.BuildServiceProvider();

        var warcraftClient = serviceProvider.GetRequiredService<WarcraftClient>();

        Assert.Equal(expectedClientId, warcraftClient.ClientId);
        Assert.Equal(expectedClientSecret, warcraftClient.ClientSecret);
        Assert.Equal(localeAndRegion.Region, warcraftClient.Region);
        Assert.Equal(localeAndRegion.Locale, warcraftClient.Locale);
    }

    [Theory]
    [MemberData(nameof(LocaleAndRegionPairs))]
    public void Then_WarcraftClient_Does_Not_Use_InternalHttpClient(ValidLocaleAndRegionPair validLocaleAndRegion)
    {
        _services.AddWarcraftClients("fake-client-id", "fake-client-secret", validLocaleAndRegion.Region,
            validLocaleAndRegion.Locale);

        IServiceProvider serviceProvider = _services.BuildServiceProvider();

        var warcraftClient = serviceProvider.GetRequiredService<WarcraftClient>();

        Assert.NotSame(InternalHttpClient.Instance, warcraftClient.Client);
    }

    [Theory]
    [MemberData(nameof(LocaleAndRegionPairs))]
    public void Then_WarcraftClient_Is_Configured_To_Accept_Json_Content(ValidLocaleAndRegionPair localeAndRegion)
    {
        _services.AddWarcraftClients("fake-client-id", "fake-client-secret", localeAndRegion.Region,
            localeAndRegion.Locale);

        IServiceProvider serviceProvider = _services.BuildServiceProvider();

        var warcraftClient = serviceProvider.GetRequiredService<WarcraftClient>();
        var acceptsJsonContent =
            warcraftClient.Client.DefaultRequestHeaders.Accept.Contains(
                new MediaTypeWithQualityHeaderValue("application/json"));

        Assert.True(acceptsJsonContent);
    }

    public class ValidLocaleAndRegionPair
    {
        public ValidLocaleAndRegionPair(Locale locale)
        {
            Locale = locale;
        }

        public Region Region => Locale.GetRegionForLocale();

        public Locale Locale { get; }
    }
}
