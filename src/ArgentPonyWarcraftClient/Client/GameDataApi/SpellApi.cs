using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public async Task<RequestResult<Spell>> GetSpellAsync(int spellId, string @namespace)
        {
            return await GetSpellAsync(spellId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<Spell>> GetSpellAsync(int spellId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await GetAsync<Spell>(region, $"{host}/data/wow/spell/{spellId}?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<SpellMedia>> GetSpellMediaAsync(int spellId, string @namespace)
        {
            return await GetSpellMediaAsync(spellId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<SpellMedia>> GetSpellMediaAsync(int spellId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await GetAsync<SpellMedia>(region, $"{host}/data/wow/media/spell/{spellId}?namespace={@namespace}&locale={locale}");
        }
    }
}
