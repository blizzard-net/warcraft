using System;
using System.Net.Http.Headers;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace ArgentPonyWarcraftClient.Extensions.DependencyInjection.Tests.ServiceCollectionExtensionsTests;

public class When_Adding_Warcraft_Clients
{
    private readonly IServiceCollection _services;

    public When_Adding_Warcraft_Clients()
    {
        _services = new ServiceCollection();

    }

    [Fact]
    public void If_Client_Id_Is_Null_Then_ArgumentNullException_Is_Thrown()
    {
        var exception = Assert.Throws<ArgumentNullException>(() =>
            _services.AddWarcraftClients(null, "fake-client-secret")
        );

        Assert.Equal("clientId", exception.ParamName);
    }

    [Fact]
    public void If_Client_Secret_Is_Null_Then_ArgumentNullException_Is_Thrown()
    {
        var exception = Assert.Throws<ArgumentNullException>(() =>
            _services.AddWarcraftClients("fake-client-id", null)
        );

        Assert.Equal("clientSecret", exception.ParamName);
    }

    [Theory]
    [ClassData(typeof(WarcraftClientInterfaceData))]
    public void Then_All_Warcraft_Interfaces_Are_Resolved_To_A_WarcraftClient_Instance(Type clientInterfaceToResolve)
    {
        _services.AddWarcraftClients("fake-client-id", "fake-client-secret");

        IServiceProvider serviceProvider = _services.BuildServiceProvider();

        var client = serviceProvider.GetRequiredService(clientInterfaceToResolve);

        Assert.IsType<WarcraftClient>(client);
    }

    [Fact]
    public void Then_WarcraftClient_Is_Created_Provided_Client_Credentials()
    {
        const string expectedClientId = "the client Id";
        const string expectedClientSecret = "the client secret";

        _services.AddWarcraftClients(expectedClientId, expectedClientSecret);

        IServiceProvider serviceProvider = _services.BuildServiceProvider();

        var warcraftClient = serviceProvider.GetRequiredService<WarcraftClient>();

        Assert.Equal(expectedClientId, warcraftClient.ClientId);
        Assert.Equal(expectedClientSecret, warcraftClient.ClientSecret);
    }

    [Fact]
    public void Then_WarcraftClient_Is_Created_With_US_Region_And_en_US_Locale()
    {
        _services.AddWarcraftClients("fake-client-id", "fake-client-secret");

        IServiceProvider serviceProvider = _services.BuildServiceProvider();

        var warcraftClient = serviceProvider.GetRequiredService<WarcraftClient>();

        Assert.Equal(Locale.en_US, warcraftClient.Locale);
        Assert.Equal(Region.US, warcraftClient.Region);
    }

    [Fact]
    public void Then_WarcraftClient_Does_Not_Use_InternalHttpClient()
    {
        _services.AddWarcraftClients("fake-client-id", "fake-client-secret");

        IServiceProvider serviceProvider = _services.BuildServiceProvider();

        var warcraftClient = serviceProvider.GetRequiredService<WarcraftClient>();

        Assert.NotSame(InternalHttpClient.Instance, warcraftClient.Client);
    }

    [Fact]
    public void Then_WarcraftClient_Is_Configured_To_Accept_Json_Content()
    {
        _services.AddWarcraftClients("fake-client-id", "fake-client-secret");

        IServiceProvider serviceProvider = _services.BuildServiceProvider();

        var warcraftClient = serviceProvider.GetRequiredService<WarcraftClient>();
        var acceptsJsonContent =
            warcraftClient.Client.DefaultRequestHeaders.Accept.Contains(
                new MediaTypeWithQualityHeaderValue("application/json"));

        Assert.True(acceptsJsonContent);
    }
}
