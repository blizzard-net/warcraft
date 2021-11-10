namespace ArgentPonyWarcraftClient.Tests.ProfileApi;

public class GuildApiTests
{
    [Fact]
    public async Task GetGuildAsync_Gets_Guild()
    {
        IGuildApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/guild/deathwing/enigma?namespace=profile-us&locale=en_US",
            responseContent: Resources.GuildResponse);

        RequestResult<Guild> result = await warcraftClient.GetGuildAsync("deathwing", "enigma", "profile-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetGuildActivityAsync_Gets_GuildActivity()
    {
        IGuildApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/guild/deathwing/enigma/activity?namespace=profile-us&locale=en_US",
            responseContent: Resources.GuildActivityResponse);

        RequestResult<GuildActivity> result = await warcraftClient.GetGuildActivityAsync("deathwing", "enigma", "profile-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetGuildAchievementsAsync_Gets_GuildAchievements()
    {
        IGuildApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/guild/deathwing/enigma/achievements?namespace=profile-us&locale=en_US",
            responseContent: Resources.GuildAchievementsResponse);

        RequestResult<GuildAchievements> result = await warcraftClient.GetGuildAchievementsAsync("deathwing", "enigma", "profile-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetGuildRosterAsync_Gets_GuildRoster()
    {
        IGuildApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/guild/deathwing/enigma/roster?namespace=profile-us&locale=en_US",
            responseContent: Resources.GuildRosterResponse);

        RequestResult<GuildRoster> result = await warcraftClient.GetGuildRosterAsync("deathwing", "enigma", "profile-us");
        Assert.NotNull(result.Value);
    }
}
