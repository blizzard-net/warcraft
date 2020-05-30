using System.Threading.Tasks;
using ArgentPonyWarcraftClient.GameData;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public async Task<RequestResult<Item>> GetItemAsync(int itemId, string @namespace)
        {
            return await GetItemAsync(itemId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<Item>> GetItemAsync(int itemId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<Item>(region, $"{host}/data/wow/item/{itemId}?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<ItemMedia>> GetItemMediaAsync(int itemId, string @namespace)
        {
            return await GetItemMediaAsync(itemId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<ItemMedia>> GetItemMediaAsync(int itemId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<ItemMedia>(region, $"{host}/data/wow/media/item/{itemId}?namespace={@namespace}&locale={locale}");
        }
    }
}
