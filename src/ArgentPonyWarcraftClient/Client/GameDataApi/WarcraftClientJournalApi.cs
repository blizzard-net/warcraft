﻿using System.Threading.Tasks;
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
    }
}
