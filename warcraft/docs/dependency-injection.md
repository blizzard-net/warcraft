---
title: Dependency Injection
---

The Argent Pony Warcraft Client includes tools to make registering the various interfaces with the `IServiceCollection` in .NET Core applications a snap!
Make sure you have installed the `ArgentPoneyWarcraftClient.Extensions.DependencyInjection` NuGet package as described in [Getting Started](./getting-started).

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
        RequestResult<CharacterProfileSummary> result =
            await _warcraftClient.GetCharacterProfileSummaryAsync("norgannon", "drinian", "profile-us");

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
        RequestResult<CharacterProfileSummary> result =
            await _characterProfileClient.GetCharacterProfileSummaryAsync(
                "norgannon", "drinian", "profile-us");

        return Ok(result);
    }
}
```
