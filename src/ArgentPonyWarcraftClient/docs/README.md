# Argent Pony Warcraft Client

The Argent Pony Warcraft Client is a .NET client for the [Blizzard World of Warcraft APIs](https://develop.battle.net/documentation/world-of-warcraft).  It lets .NET applications easily access information about World of Warcraft characters, guilds, items, spells, and more.  It is a [.NET Standard](https://docs.microsoft.com/en-us/dotnet/standard/net-standard) 2.0 library, which means it supports a broad range of platforms, including .NET Core 2.0+ and .NET Framework 4.6.1+.

## Documentation

Documentation is available at [https://blizzard-net.github.io/warcraft/](https://blizzard-net.github.io/warcraft/)

## Usage

The `WarcraftClient` class provides access to the World of Warcraft APIs.

```cs
// Secrets from https://develop.battle.net/documentation/guides/getting-started.
string clientId = "MY-CLIENT-ID-GOES-HERE";
string clientSecret = "MY-CLIENT-SECRET-GOES-HERE";
var warcraftClient = new WarcraftClient(clientId, clientSecret);

// Retrieve the character profile for Drinian of realm Norgannon.
RequestResult<CharacterProfileSummary> result =
    await warcraftClient.GetCharacterProfileSummaryAsync("norgannon", "drinian", "profile-us");

// If we got it, display the level.
if (result.Success)
{
    CharacterProfileSummary profile = result.Value;
    Console.WriteLine($"Level for {profile.Name}: {profile.Level}");
}
```

See [Getting Started](https://blizzard-net.github.io/warcraft/docs/getting-started) and [Using the Library](https://blizzard-net.github.io/warcraft/docs/usage) for detailed instructions.

## Feedback

Report problems in the [GitHub Issues](https://github.com/blizzard-net/warcraft/issues) for the project or join the [Discussions](https://github.com/blizzard-net/warcraft/discussions).
