---
title: Using the Library
---

Assuming you're working in C#, add the appropriate `using` statement to reference the library:

```cs
using ArgentPonyWarcraftClient;
```

Instantiate a `WarcraftClient` with the the client ID and client secret that you registered for in the [Prerequisites](./#prerequisites) step.  For simplicity, these values are stored in the source code in the example below.  You should instead use the configuration API for your .NET platform to store the key securely.  For example, ASP.NET Core developers should read [Configuration in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration).

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
RequestResult<CharacterProfileSummary> result =
    await warcraftClient.GetCharacterProfileSummaryAsync("norgannon", "drinian", "profile-us");
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
RequestResult<CharacterProfileSummary> result =
    await warcraftClient.GetCharacterProfileSummaryAsync("norgannon", "drinian", "profile-us");

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
