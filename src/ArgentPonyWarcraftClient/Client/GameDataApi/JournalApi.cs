namespace ArgentPonyWarcraftClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<JournalExpansionsIndex>> GetJournalExpansionsIndexAsync(string @namespace)
    {
        return await GetJournalExpansionsIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<JournalExpansionsIndex>> GetJournalExpansionsIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<JournalExpansionsIndex>($"{host}/data/wow/journal-expansion/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<JournalExpansion>> GetJournalExpansionAsync(int journalExpansionId, string @namespace)
    {
        return await GetJournalExpansionAsync(journalExpansionId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<JournalExpansion>> GetJournalExpansionAsync(int journalExpansionId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<JournalExpansion>($"{host}/data/wow/journal-expansion/{journalExpansionId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<JournalEncountersIndex>> GetJournalEncountersIndexAsync(string @namespace)
    {
        return await GetJournalEncountersIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<JournalEncountersIndex>> GetJournalEncountersIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<JournalEncountersIndex>($"{host}/data/wow/journal-encounter/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<Encounter>> GetJournalEncounterAsync(int journalEncounterId, string @namespace)
    {
        return await GetJournalEncounterAsync(journalEncounterId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<Encounter>> GetJournalEncounterAsync(int journalEncounterId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<Encounter>($"{host}/data/wow/journal-encounter/{journalEncounterId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<JournalInstancesIndex>> GetJournalInstancesIndexAsync(string @namespace)
    {
        return await GetJournalInstancesIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<JournalInstancesIndex>> GetJournalInstancesIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<JournalInstancesIndex>($"{host}/data/wow/journal-instance/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<Instance>> GetJournalInstanceAsync(int journalInstanceId, string @namespace)
    {
        return await GetJournalInstanceAsync(journalInstanceId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<Instance>> GetJournalInstanceAsync(int journalInstanceId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<Instance>($"{host}/data/wow/journal-instance/{journalInstanceId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<JournalInstanceMedia>> GetJournalInstanceMediaAsync(int journalInstanceId, string @namespace)
    {
        return await GetJournalInstanceMediaAsync(journalInstanceId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<JournalInstanceMedia>> GetJournalInstanceMediaAsync(int journalInstanceId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<JournalInstanceMedia>($"{host}/data/wow/media/journal-instance/{journalInstanceId}?namespace={@namespace}&locale={locale}");
    }
}
