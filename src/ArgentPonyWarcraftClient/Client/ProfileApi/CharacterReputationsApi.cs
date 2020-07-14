using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public async Task<RequestResult<CharacterReputationsSummary>> GetCharacterReputationsSummaryAsync(string realmSlug, string characterName, string @namespace)
        {
            return await GetCharacterReputationsSummaryAsync(realmSlug, characterName, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<CharacterReputationsSummary>> GetCharacterReputationsSummaryAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<CharacterReputationsSummary>(region, $"{host}/profile/wow/character/{realmSlug}/{characterName?.ToLowerInvariant()}/reputations?namespace={@namespace}&locale={locale}");
        }
    }
}
