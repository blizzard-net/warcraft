using System.Threading.Tasks;
using ArgentPonyWarcraftClient.GameData;

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
            return await Get<JournalExpansionsIndex>(region, $"{host}/data/wow/journal-expansion/index?namespace={@namespace}&locale={locale}");
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
            return await Get<JournalExpansion>(region, $"{host}/data/wow/journal-expansion/{@journalExpansionId}?namespace={@namespace}&locale={locale}");
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
            return await Get<JournalEncountersIndex>(region, $"{host}/data/wow/journal-encounter/index?namespace={@namespace}&locale={locale}");
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
            return await Get<Encounter>(region, $"{host}/data/wow/journal-encounter/{@journalEncounterId}?namespace={@namespace}&locale={locale}");
        }
    }
}
