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
            return await Get<PetsIndex>(region, $"{host}/data/wow/pet/index?namespace={@namespace}&locale={locale}");
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
            return await Get<Pet>(region, $"{host}/data/wow/pet/{petId}?namespace={@namespace}&locale={locale}");
        }
    }
}
