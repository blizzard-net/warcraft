using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public async Task<RequestResult<JournalExpansionsIndex>> GetJournalExpansionsIndexAsync(string @namespace)
        {
            return await GetJournalExpansionsIndexAsync(@namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<JournalExpansionsIndex>> GetJournalExpansionsIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await GetAsync<JournalExpansionsIndex>(region, $"{host}/data/wow/journal-expansion/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<JournalExpansion>> GetJournalExpansionAsync(int journalExpansionId, string @namespace)
        {
            return await GetJournalExpansionAsync(journalExpansionId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<JournalExpansion>> GetJournalExpansionAsync(int journalExpansionId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await GetAsync<JournalExpansion>(region, $"{host}/data/wow/journal-expansion/{journalExpansionId}?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<JournalEncountersIndex>> GetJournalEncountersIndexAsync(string @namespace)
        {
            return await GetJournalEncountersIndexAsync(@namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<JournalEncountersIndex>> GetJournalEncountersIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await GetAsync<JournalEncountersIndex>(region, $"{host}/data/wow/journal-encounter/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<Encounter>> GetJournalEncounterAsync(int journalEncounterId, string @namespace)
        {
            return await GetJournalEncounterAsync(journalEncounterId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<Encounter>> GetJournalEncounterAsync(int journalEncounterId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await GetAsync<Encounter>(region, $"{host}/data/wow/journal-encounter/{journalEncounterId}?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<JournalInstancesIndex>> GetJournalInstancesIndexAsync(string @namespace)
        {
            return await GetJournalInstancesIndexAsync(@namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<JournalInstancesIndex>> GetJournalInstancesIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await GetAsync<JournalInstancesIndex>(region, $"{host}/data/wow/journal-instance/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<Instance>> GetJournalInstanceAsync(int journalInstanceId, string @namespace)
        {
            return await GetJournalInstanceAsync(journalInstanceId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<Instance>> GetJournalInstanceAsync(int journalInstanceId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await GetAsync<Instance>(region, $"{host}/data/wow/journal-instance/{journalInstanceId}?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<JournalInstanceMedia>> GetJournalInstanceMediaAsync(int journalInstanceId, string @namespace)
        {
            return await GetJournalInstanceMediaAsync(journalInstanceId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<JournalInstanceMedia>> GetJournalInstanceMediaAsync(int journalInstanceId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await GetAsync<JournalInstanceMedia>(region, $"{host}/data/wow/media/journal-instance/{journalInstanceId}?namespace={@namespace}&locale={locale}");
        }
    }
}
