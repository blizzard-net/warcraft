# Argent Pony Warcraft Client

The Argent Pony Warcraft Client is a .NET client for the [Blizzard World of Warcraft APIs](https://develop.battle.net/documentation/world-of-warcraft).  It lets .NET applications easily access information about World of Warcraft characters, guilds, items, spells, and more.  It is a [.NET Standard](https://docs.microsoft.com/en-us/dotnet/standard/net-standard) 2.0 library, which means it supports a broad range of platforms, including .NET Core 2.0+ and .NET Framework 4.6.1+.

[![NuGet version](https://badge.fury.io/nu/ArgentPonyWarcraftClient.svg)](https://badge.fury.io/nu/ArgentPonyWarcraftClient)
[![build](https://github.com/blizzard-net/warcraft/actions/workflows/build.yml/badge.svg)](https://github.com/blizzard-net/warcraft/actions/workflows/build.yml)
[![CodeQL](https://github.com/blizzard-net/warcraft/actions/workflows/codeql-analysis.yml/badge.svg)](https://github.com/blizzard-net/warcraft/actions/workflows/codeql-analysis.yml)

## Prerequisites

All users of the Blizzard World of Warcraft Game Data and Profile APIs must have a Battle.net account and a client ID.  Follow Blizzard's [Getting Started](https://develop.battle.net/documentation/guides/getting-started) instructions.

## Installing via NuGet

You can install the **ArgentPonyWarcraftClient** package from the NuGet Package Manager in Visual Studio or by running the following command from the Package Manager Console:

```shell
Install-Package ArgentPonyWarcraftClient
```

## Using the Argent Pony Warcraft Client

Assuming you're working in C#, add the appropriate `using` statement to reference the library:

```cs
using ArgentPonyWarcraftClient;
```

Instantiate a `WarcraftClient` with the the client ID and client secret that you registered for in the **Prerequisites** step.  For simplicity, these values are stored in the source code in the example below.  You should instead use the configuration API for your .NET platform to store the key securely.  For example, ASP.NET Core developers should read [Configuration in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration).

```cs
string clientId = "MY-CLIENT-ID-GOES-HERE";
string clientSecret = "MY-CLIENT-SECRET-GOES-HERE";
var warcraftClient = new WarcraftClient(clientId, clientSecret);
```

You can optionally specify the region and locale to use when calling the `WarcraftClient` constructor.  If you omit these parameters, it will default to `Region.US` and `"Locale.en_US"`.  Each method on `WarcraftClient` also has an overload that allows you to override these default values for the current call.

```cs
var warcraftClient = new WarcraftClient(clientId, clientSecret, Region.US, "Locale.en_US");
```

Once you have your `WarcraftClient` instance, you can start asking for data.  All methods are asynchronous.  Here's an example for retrieving a character:

```cs
RequestResult<CharacterProfileSummary> result = await warcraftClient.GetCharacterProfileSummaryAsync("norgannon", "drinian", "profile-us");
```

This will retrieve the summary for a character named Drinian from the realm Norgannon.

Each request is wrapped in the `RequestResult<T>` class. Which has the following properties.

* Value (The generic type argument)
* Error (RequestError class)
  * Code (The HTTP status code)
  * Type (The HTTP status code description)
  * Detail (The details of why the request failed)
* Success (bool)

A proper method call could look like this.

```cs
RequestResult<CharacterProfileSummary> result = await warcraftClient.GetCharacterProfileSummaryAsync("norgannon", "drinian", "profile-us");

if (result.Success)
{
    CharacterProfileSummary character = result.Value;
    Console.WriteLine("Character Name: " + character.Name);
    Console.WriteLine("Character Level: " + character.Level);
}
else
{
    RequestError error = result.Error;
    Console.WriteLine("HTTP Status Code: " + error.Code);
    Console.WriteLine("HTTP Status Description: " + error.Type);
    Console.WriteLine("Details: " + error.Detail);
}
```

Take a look at the [ArgentPonyWarcraftClient.Tests](https://github.com/blizzard-net/warcraft/tree/master/tests/ArgentPonyWarcraftClient.Tests) project and the Blizzard World of Warcraft Game Data and Profile APIs documentation to learn more about what else you can do.

## Using with Dependency Injection

The Argent Pony Warcraft Client includes tools to make registering the various interfaces with the `IServiceCollection` in .NET Core applications a snap!

### Installing dependency injection via NuGet

You can install the ArgentPonyWarcraftClient.Extensions.DependencyInjection package from the NuGet Package Manager in Visual Studio or by running the following command from the Package Manager Console:

```shell
Install-Package ArgentPonyWarcraftClient.Extensions.DependencyInjection
```

### Register services

To start off, add the appropriate `using` statement to the file.

```cs
using ArgentPoneyWarcraftClient.Extensions.DependencyInjection;
```

Then use the `AddWarcraftClients()` method on the `IServiceCollection` instance. For example, in ASP.NET Core applications this would be in the `ConfigureServices()` method like so.

```cs
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        string clientId = "MY-CLIENT-ID-GOES-HERE";
        string clientSecret = "MY-CLIENT-SECRET-GOES-HERE";

        services.AddWarcraftClients(clientId, clientSecret);
    }
}
```

Similar to directly instantiating the `WarcraftClient`, you also have the option to specify the locale and region you want to use.

```cs
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        string clientId = "MY-CLIENT-ID-GOES-HERE";
        string clientSecret = "MY-CLIENT-SECRET-GOES-HERE";

        services.AddWarcraftClients(clientId, clientSecret, Region.Europe, Locale.en_GB);
    }
}
```

Once the services are registered with the container you can list them as dependencies for your controllers or services.

```cs
public class CharacterProfileController
{
    private readonly IWarcraftClient _warcraftClient;

    public CharacterProfileController(IWarcraftClient warcraftClient)
    {
        _warcraftClient = warcraftClient;
    }

    public async Task<ActionResult> GetCharacterProfileSummary()
    {
        RequestResult<CharacterProfileSummary> result = await _warcraftClient.GetCharacterProfileSummaryAsync("norgannon", "drinian", "profile-us");

        return Ok(result);
    }
}
```

In addition to registering the `IWarcraftClient`, it registers all of the discrete interfaces as well, such as the `IProfileApi` or `IAchievementApi`. This allows your component to depend only on the specific APIs you need.

```cs
public class CharacterProfileController
{
    private readonly ICharacterProfileApi _characterProfileClient;

    public CharacterProfileController(ICharacterProfileApi characterProfileClient)
    {
        _characterProfileClient = characterProfileClient;
    }

    public async Task<ActionResult> GetCharacterProfileSummary()
    {
        RequestResult<CharacterProfileSummary> result = await _characterProfileClient.GetCharacterProfileSummaryAsync("norgannon", "drinian", "profile-us");

        return Ok(result);
    }
}
```
