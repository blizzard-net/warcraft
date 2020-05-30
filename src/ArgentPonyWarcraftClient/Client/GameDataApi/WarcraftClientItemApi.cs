﻿using System.Threading.Tasks;
using ArgentPonyWarcraftClient.GameData;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public async Task<RequestResult<ItemClassesIndex>> GetItemClassesIndexAsync(string @namespace)
        {
            return await GetItemClassesIndexAsync(@namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<ItemClassesIndex>> GetItemClassesIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<ItemClassesIndex>(region, $"{host}/data/wow/item-class/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<ItemClass>> GetItemClassAsync(int itemClassId, string @namespace)
        {
            return await GetItemClassAsync(itemClassId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<ItemClass>> GetItemClassAsync(int itemClassId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<ItemClass>(region, $"{host}/data/wow/item-class/{itemClassId}?namespace={@namespace}&locale={locale}");
        }

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
