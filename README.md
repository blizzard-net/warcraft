# Argent Pony Warcraft Client

The Argent Pony Warcraft Client is a .NET client for the [Blizzard World of Warcraft APIs](https://develop.battle.net/documentation/world-of-warcraft).  It lets .NET applications easily access information about World of Warcraft characters, guilds, items, spells, and more.  It is a [.NET Standard](https://docs.microsoft.com/en-us/dotnet/standard/net-standard) 2.0 library, which means it supports a broad range of platforms, including .NET Core 2.0+ and .NET Framework 4.6.1+.

[![NuGet version](https://badge.fury.io/nu/ArgentPonyWarcraftClient.svg)](https://badge.fury.io/nu/ArgentPonyWarcraftClient)
[![build](https://github.com/blizzard-net/warcraft/actions/workflows/build.yml/badge.svg)](https://github.com/blizzard-net/warcraft/actions/workflows/build.yml)
[![CodeQL](https://github.com/blizzard-net/warcraft/actions/workflows/codeql-analysis.yml/badge.svg)](https://github.com/blizzard-net/warcraft/actions/workflows/codeql-analysis.yml)

## Documentation

Documentation is available at [https://blizzard-net.github.io/warcraft/](https://blizzard-net.github.io/warcraft/)

- [Introduction](https://blizzard-net.github.io/warcraft/docs/)
- [Getting Started](https://blizzard-net.github.io/warcraft/docs/getting-started)
- [Using the Library](https://blizzard-net.github.io/warcraft/docs/usage)
- [Dependency Injection](https://blizzard-net.github.io/warcraft/docs/dependency-injection)

## Quick Start

Create a new Console Application in Visual Studio or via [dotnet new](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new).

```shell
dotnet new console --name QuickStart
```

Add the [ArgentPonyWarcraftClient](https://www.nuget.org/packages/ArgentPonyWarcraftClient) NuGet package to the project:

```shell
dotnet add QuickStart package ArgentPonyWarcraftClient
```

Update **Program.cs** in the new project as follows, subsituting your own client ID and secret from Blizzard's [Getting Started](https://develop.battle.net/documentation/guides/getting-started) instructions:

```cs
using System;
using System.Threading.Tasks;
using ArgentPonyWarcraftClient;

namespace QuickStart
{
    class Program
    {
        static async Task Main(string[] args)
        {
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
        }
    }
}
```

Build and run the console application.

```shell
cd QuickStart
dotnet run
```

The console output displays the profile data that was retrieved from the Blizzard Character Profile API.
The library supports many other APIs, too.

```shell
Level for Drinian: 60
```
