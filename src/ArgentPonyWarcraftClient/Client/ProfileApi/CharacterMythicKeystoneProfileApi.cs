using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public async Task<RequestResult<CharacterMythicKeystoneProfileIndex>> GetCharacterMythicKeystoneProfileIndexAsync(string realmSlug, string characterName, string @namespace)
        {
            return await GetCharacterMythicKeystoneProfileIndexAsync(realmSlug, characterName, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<CharacterMythicKeystoneProfileIndex>> GetCharacterMythicKeystoneProfileIndexAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<CharacterMythicKeystoneProfileIndex>(region, $"{host}/profile/wow/character/{realmSlug}/{characterName?.ToLowerInvariant()}/mythic-keystone-profile?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<CharacterMythicKeystoneSeasonDetails>> GetCharacterMythicKeystoneSeasonDetailsAsync(string realmSlug, string characterName, int seasonId, string @namespace)
        {
            return await GetCharacterMythicKeystoneSeasonDetailsAsync(realmSlug, characterName, seasonId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<CharacterMythicKeystoneSeasonDetails>> GetCharacterMythicKeystoneSeasonDetailsAsync(string realmSlug, string characterName, int seasonId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<CharacterMythicKeystoneSeasonDetails>(region, $"{host}/profile/wow/character/{realmSlug}/{characterName?.ToLowerInvariant()}/mythic-keystone-profile/season/{seasonId}?namespace={@namespace}&locale={locale}");
        }
    }
}
