# Argent Pony Warcraft Client
The Argent Pony Warcraft Client is a .NET client for the [Blizzard World of Warcraft Community Web APIs](https://dev.battle.net/).  It lets .NET applications easily access information about World of Warcraft characters, guilds, items, spells, and more.  It is a [.NET Standard](https://docs.microsoft.com/en-us/dotnet/standard/net-standard) 1.1 library, which means it supports a broad range of platforms, including .NET Core 1.0+ and .NET Framework 4.5+.

[![NuGet version](https://badge.fury.io/nu/ArgentPonyWarcraftClient.svg)](https://badge.fury.io/nu/ArgentPonyWarcraftClient)

## Prerequisites

All users of the Blizzard World of Warcraft Community Web APIs must have an API key.  Follow Blizzard's instructions to [register a new Mashery ID](https://dev.battle.net/member/register).

## Installing via NuGet

You can install the **ArgentPonyWarcraftClient** package from the NuGet Package Manager in Visual Studio or by running the following command from the Package Manager Console:

```
Install-Package ArgentPonyWarcraftClient
```

## Using the Argent Pony Warcraft Client

Assuming you're working in C#, add the appropriate `using` statement to reference the library:

``` cs
using ArgentPonyWarcraftClient;
```

Instantiate a `WarcraftClient` with the the API key that you registered for in the **Prerequisites** step.  For simplicity, the key is stored in the source code in the example below.  You should instead use the configuration API for your .NET platform to store the key securely.  For example, ASP.NET Core developers should read [Configuration in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration).

``` cs
string apiKey = "MY-API-KEY-GOES-HERE";
var warcraftClient = new WarcraftClient(apiKey);
```

You can optionally specify the region and locale to use when calling the `WarcraftClient` constructor.  If you omit these parameters, it will default to `Region.US` and `"en_US"`.  Each method on `WarcraftClient` also has an overload that allows you to override these default values for the current call.

``` cs
var warcraftClient = new WarcraftClient(apiKey, Region.US, "en_US");
```

Once you have your `WarcraftClient` instance, you can start asking for data.  All methods are asynchronous.  Here's an example for retrieving a character:

``` cs
Character character = await warcraftClient.GetCharacterAsync("Norgannon", "Drinian", CharacterFields.All);
```

This will retrieve a character named Drinian from the realm Norgannon.  The `CharacterFields` enumeration allows you to specify which portions of character-related data the Blizzard API should return.  If you only want to retrieve information about the character's talents and mounts, for instance, you can ask for only those portions of the `Character` object to be populated.

``` cs
CharacterFields fields = CharacterFields.Talents | CharacterFields.Mounts;
Character character = await warcraftClient.GetCharacterAsync("Norgannon", "Drinian", fields);
```

Take a look at the [WarcraftClientTests](https://github.com/danjagnow/ArgentPonyWarcraftClient/blob/master/src/ArgentPonyWarcraftClient.Tests/WarcraftClientTests.cs) class and the Blizzard World of Warcraft Community Web APIs documentation to learn more about what else you can do.
