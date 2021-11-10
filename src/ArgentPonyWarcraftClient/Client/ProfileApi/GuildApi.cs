namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<Guild>> GetGuildAsync(string realmSlug, string nameSlug, string @namespace)
    {
        return await GetGuildAsync(realmSlug, nameSlug, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<Guild>> GetGuildAsync(string realmSlug, string nameSlug, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<Guild>($"{host}/data/wow/guild/{realmSlug}/{nameSlug?.ToLowerInvariant()}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<GuildActivity>> GetGuildActivityAsync(string realmSlug, string nameSlug, string @namespace)
    {
        return await GetGuildActivityAsync(realmSlug, nameSlug, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<GuildActivity>> GetGuildActivityAsync(string realmSlug, string nameSlug, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<GuildActivity>($"{host}/data/wow/guild/{realmSlug}/{nameSlug?.ToLowerInvariant()}/activity?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<GuildAchievements>> GetGuildAchievementsAsync(string realmSlug, string nameSlug, string @namespace)
    {
        return await GetGuildAchievementsAsync(realmSlug, nameSlug, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<GuildAchievements>> GetGuildAchievementsAsync(string realmSlug, string nameSlug, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<GuildAchievements>($"{host}/data/wow/guild/{realmSlug}/{nameSlug?.ToLowerInvariant()}/achievements?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<GuildRoster>> GetGuildRosterAsync(string realmSlug, string nameSlug, string @namespace)
    {
        return await GetGuildRosterAsync(realmSlug, nameSlug, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<GuildRoster>> GetGuildRosterAsync(string realmSlug, string nameSlug, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<GuildRoster>($"{host}/data/wow/guild/{realmSlug}/{nameSlug?.ToLowerInvariant()}/roster?namespace={@namespace}&locale={locale}");
    }
}
