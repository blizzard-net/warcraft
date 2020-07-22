using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public async Task<RequestResult<PetsIndex>> GetPetsIndexAsync(string @namespace)
        {
            return await GetPetsIndexAsync(@namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<PetsIndex>> GetPetsIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await GetAsync<PetsIndex>(region, $"{host}/data/wow/pet/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<Pet>> GetPetAsync(int petId, string @namespace)
        {
            return await GetPetAsync(petId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<Pet>> GetPetAsync(int petId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await GetAsync<Pet>(region, $"{host}/data/wow/pet/{petId}?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<PetAbilitiesIndex>> GetPetAbilitiesIndexAsync(string @namespace)
        {
            return await GetPetAbilitiesIndexAsync(@namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<PetAbilitiesIndex>> GetPetAbilitiesIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await GetAsync<PetAbilitiesIndex>(region, $"{host}/data/wow/pet-ability/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<PetAbility>> GetPetAbilityAsync(int petAbilityId, string @namespace)
        {
            return await GetPetAbilityAsync(petAbilityId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<PetAbility>> GetPetAbilityAsync(int petAbilityId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await GetAsync<PetAbility>(region, $"{host}/data/wow/pet-ability/{petAbilityId}?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<PetAbilityMedia>> GetPetAbilityMediaAsync(int petAbilityId, string @namespace)
        {
            return await GetPetAbilityMediaAsync(petAbilityId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<PetAbilityMedia>> GetPetAbilityMediaAsync(int petAbilityId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await GetAsync<PetAbilityMedia>(region, $"{host}/data/wow/media/pet-ability/{petAbilityId}?namespace={@namespace}&locale={locale}");
        }
    }
}
