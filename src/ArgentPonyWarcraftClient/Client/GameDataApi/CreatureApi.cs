using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public async Task<RequestResult<CreatureFamiliesIndex>> GetCreatureFamiliesIndexAsync(string @namespace)
        {
            return await GetCreatureFamiliesIndexAsync(@namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<CreatureFamiliesIndex>> GetCreatureFamiliesIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<CreatureFamiliesIndex>(region, $"{host}/data/wow/creature-family/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<CreatureFamily>> GetCreatureFamilyAsync(int creatureFamilyId, string @namespace)
        {
            return await GetCreatureFamilyAsync(creatureFamilyId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<CreatureFamily>> GetCreatureFamilyAsync(int creatureFamilyId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<CreatureFamily>(region, $"{host}/data/wow/creature-family/{creatureFamilyId}?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<CreatureTypesIndex>> GetCreatureTypesIndexAsync(string @namespace)
        {
            return await GetCreatureTypesIndexAsync(@namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<CreatureTypesIndex>> GetCreatureTypesIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<CreatureTypesIndex>(region, $"{host}/data/wow/creature-type/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<CreatureType>> GetCreatureTypeAsync(int creatureTypeId, string @namespace)
        {
            return await GetCreatureTypeAsync(creatureTypeId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<CreatureType>> GetCreatureTypeAsync(int creatureTypeId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<CreatureType>(region, $"{host}/data/wow/creature-type/{creatureTypeId}?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<Creature>> GetCreatureAsync(int creatureId, string @namespace)
        {
            return await GetCreatureAsync(creatureId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<Creature>> GetCreatureAsync(int creatureId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<Creature>(region, $"{host}/data/wow/creature/{creatureId}?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<CreatureDisplayMedia>> GetCreatureDisplayMediaAsync(int creatureDisplayId, string @namespace)
        {
            return await GetCreatureDisplayMediaAsync(creatureDisplayId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<CreatureDisplayMedia>> GetCreatureDisplayMediaAsync(int creatureDisplayId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<CreatureDisplayMedia>(region, $"{host}/data/wow/media/creature-display/{creatureDisplayId}?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<CreatureFamilyMedia>> GetCreatureFamilyMediaAsync(int creatureFamilyId, string @namespace)
        {
            return await GetCreatureFamilyMediaAsync(creatureFamilyId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<CreatureFamilyMedia>> GetCreatureFamilyMediaAsync(int creatureFamilyId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<CreatureFamilyMedia>(region, $"{host}/data/wow/media/creature-family/{creatureFamilyId}?namespace={@namespace}&locale={locale}");
        }
    }
}
