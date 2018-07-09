using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    ///     A client for the World of Warcraft Community APIs.
    /// </summary>
    public class WarcraftClient : IWarcraftClient
    {
        private readonly HttpClient _client;
        private readonly string _apiKey;
        private readonly Region _region;
        private readonly Locale _locale;

        /// <summary>
        ///     Initializes a new instance of the <see cref="WarcraftClient"/> class.
        /// </summary>
        /// <remarks>
        ///     Defaults the region to US and the locale to "en_US".
        /// </remarks>
        /// <param name="apiKey">The API key.</param>
        public WarcraftClient(string apiKey) : this(apiKey, Region.US, Locale.en_US)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="WarcraftClient"/> class.
        /// </summary>
        /// <param name="apiKey">Blizzard Mashery API key. To create an API key visit https://dev.battle.net/member/register </param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">
        ///     Specifies the language that the result will be in. Visit
        ///     https://dev.battle.net/docs/read/community_apis to see a list of available locales.
        /// </param>
        public WarcraftClient(string apiKey, Region region, Locale locale) : this (apiKey, region, locale, InternalHttpClient.Instance)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="WarcraftClient"/> class.
        /// </summary>
        /// <param name="apiKey">Blizzard Mashery API key. To create an API key visit https://dev.battle.net/member/register </param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">
        ///     Specifies the language that the result will be in. Visit
        ///     https://dev.battle.net/docs/read/community_apis to see a list of available locales.
        /// </param>
        /// <param name="client">The <see cref="HttpClient"/> that communicates with Blizzard.</param>
        public WarcraftClient(string apiKey, Region region, Locale locale, HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
            _apiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));

            if (!ValidateRegionLocale(locale, region))
            {
                throw new ArgumentException("The locale selected is not supported by the selected region.");
            }

            _region = region;
            _locale = locale;
        }

        /// <summary>
        ///     Get the specified achievement.
        /// </summary>
        /// <param name="id">The achievement ID.</param>
        /// <returns>
        ///     The specified achievement.
        /// </returns>
        public async Task<RequestResult<Achievement>> GetAchievementAsync(int id)
        {
            return await GetAchievementAsync(id, _region, _locale);
        }

        /// <summary>
        ///     Get the specified achievement.
        /// </summary>
        /// <param name="id">The achievement ID.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     The specified achievement.
        /// </returns>
        public async Task<RequestResult<Achievement>> GetAchievementAsync(int id, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<Achievement>($"{host}/wow/achievement/{id}?locale={locale}&apikey={_apiKey}");
        }

        /// <summary>
        ///     Get the specified auction.
        /// </summary>
        /// <param name="realm">The realm.</param>
        /// <returns>
        ///     The specified auction.
        /// </returns>
        public async Task<RequestResult<AuctionFiles>> GetAuctionAsync(string realm)
        {
            return await GetAuctionAsync(realm, _region, _locale);
        }

        /// <summary>
        ///     Get the specified auction.
        /// </summary>
        /// <param name="realm">The realm.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     The specified auction.
        /// </returns>
        public async Task<RequestResult<AuctionFiles>> GetAuctionAsync(string realm, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<AuctionFiles>($"{host}/wow/auction/data/{realm}?locale={locale}&apikey={_apiKey}");
        }

        /// <summary>
        ///     Get the auction house snapshot from the specified file.
        /// </summary>
        /// <param name="url">The URL for the auction house file.</param>
        /// <returns>
        ///     The auction house snapshot from the specified file.
        /// </returns>
        public async Task<RequestResult<AuctionHouseSnapshot>> GetAuctionHouseSnapshotAsync(string url)
        {
            return await Get<AuctionHouseSnapshot>(url);
        }

        /// <summary>
        ///     Get a list of all supported battlegroups.
        /// </summary>
        /// <returns>
        ///     A list of all supported battlegroups.
        /// </returns>
        public async Task<RequestResult<IList<Battlegroup>>> GetBattlegroupsAsync()
        {
            return await GetBattlegroupsAsync(_region, _locale);
        }

        /// <summary>
        ///     Get a list of all supported battlegroups.
        /// </summary>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     A list of all supported battlegroups.
        /// </returns>
        public async Task<RequestResult<IList<Battlegroup>>> GetBattlegroupsAsync(Region region, Locale locale)
        {
            string host = GetHost(region);
            RequestResult<IList<Battlegroup>> battlegroupList = await Get<IList<Battlegroup>>($"{host}/wow/data/battlegroups/?locale={locale}&apikey={_apiKey}", "battlegroups");

            return battlegroupList;
        }

        /// <summary>
        ///     Get the specified boss.
        /// </summary>
        /// <remarks>
        ///     A "boss" in this context should be considered a boss encounter, which may include more than one NPC.
        /// </remarks>
        /// <param name="id">The boss ID.</param>
        /// <returns>
        ///     The specified boss.
        /// </returns>
        public async Task<RequestResult<Boss>> GetBossAsync(int id)
        {
            return await GetBossAsync(id, _region, _locale);
        }

        /// <summary>
        ///     Get the specified boss.
        /// </summary>
        /// <remarks>
        ///     A "boss" in this context should be considered a boss encounter, which may include more than one NPC.
        /// </remarks>
        /// <param name="id">The boss ID.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     The specified boss.
        /// </returns>
        public async Task<RequestResult<Boss>> GetBossAsync(int id, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<Boss>($"{host}/wow/boss/{id}?locale={locale}&apikey={_apiKey}");
        }

        /// <summary>
        ///     Get a list of all supported bosses.
        /// </summary>
        /// <remarks>
        ///     A "boss" in this context should be considered a boss encounter, which may include more than one NPC.
        /// </remarks>
        /// <returns>
        ///     A list of all supported bosses.
        /// </returns>
        public async Task<RequestResult<IList<Boss>>> GetBossesAsync()
        {
            return await GetBossesAsync(_region, _locale);
        }

        /// <summary>
        ///     Get a list of all supported bosses.
        /// </summary>
        /// <remarks>
        ///     A "boss" in this context should be considered a boss encounter, which may include more than one NPC.
        /// </remarks>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     A list of all supported bosses.
        /// </returns>
        public async Task<RequestResult<IList<Boss>>> GetBossesAsync(Region region, Locale locale)
        {
            string host = GetHost(region);
            RequestResult<IList<Boss>> bossList = await Get<IList<Boss>>($"{host}/wow/boss/?locale={locale}&apikey={_apiKey}", "bosses");
            return bossList;
        }

        /// <summary>
        ///     Get the challenge mode data for the entire region.
        /// </summary>
        /// <returns>
        ///     The challenge mode data for the entire region.
        /// </returns>
        public async Task<RequestResult<IList<Challenge>>> GetChallengesAsync()
        {
            return await GetChallengesAsync(_region, _locale);
        }

        /// <summary>
        ///     Get the challenge mode data for the entire region.
        /// </summary>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     The challenge mode data for the entire region.
        /// </returns>
        public async Task<RequestResult<IList<Challenge>>> GetChallengesAsync(Region region, Locale locale)
        {
            string host = GetHost(region);
            RequestResult<IList<Challenge>> challengeList = await Get<IList<Challenge>>($"{host}/wow/challenge/region?locale={locale}&apikey={_apiKey}", "challenge");
            return challengeList;
        }

        /// <summary>
        ///     Get the challenge mode data for the specified realm.
        /// </summary>
        /// <param name="realm">The realm.</param>
        /// <returns>
        ///     The challenge mode data for the specified realm.
        /// </returns>
        public async Task<RequestResult<IList<Challenge>>> GetChallengesAsync(string realm)
        {
            return await GetChallengesAsync(realm, _region, _locale);
        }

        /// <summary>
        ///     Get the challenge mode data for the specified realm.
        /// </summary>
        /// <param name="realm">The realm.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     The challenge mode data for the specified realm.
        /// </returns>
        public async Task<RequestResult<IList<Challenge>>> GetChallengesAsync(string realm, Region region, Locale locale)
        {
            string host = GetHost(region);
            RequestResult<IList<Challenge>> challengeList = await Get<IList<Challenge>>($"{host}/wow/challenge/{realm}?locale={locale}&apikey={_apiKey}", "challenge");
            return challengeList;
        }

        /// <summary>
        ///     Get the specified character.
        /// </summary>
        /// <param name="realm">The realm.</param>
        /// <param name="characterName">The character name.</param>
        /// <param name="fields">The character fields to include.</param>
        /// <returns>
        ///     The specified character.
        /// </returns>>
        public async Task<RequestResult<Character>> GetCharacterAsync(string realm, string characterName, CharacterFields fields = CharacterFields.None)
        {
            return await GetCharacterAsync(realm, characterName, _region, _locale, fields);
        }

        /// <summary>
        ///     Get the specified character.
        /// </summary>
        /// <param name="realm">The realm.</param>
        /// <param name="characterName">The character name.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <param name="fields">The character fields to include.</param>
        /// <returns>
        ///     The specified character.
        /// </returns>
        public async Task<RequestResult<Character>> GetCharacterAsync(string realm, string characterName, Region region, Locale locale, CharacterFields fields = CharacterFields.None)
        {
            string host = GetHost(region);
            string queryStringFields = fields.BuildQueryString();
            return await Get<Character>($"{host}/wow/character/{realm}/{characterName}?&locale={locale}{queryStringFields}&apikey={_apiKey}");
        }

        /// <summary>
        ///     Get a list of all of the achievements that characters can earn as well as the category structure and hierarchy.
        /// </summary>
        /// <returns>
        ///     A list of all of the achievements that characters can earn as well as the category structure and hierarchy.
        /// </returns>
        public async Task<RequestResult<IList<AchievementCategory>>> GetCharacterAchievementsAsync()
        {
            return await GetCharacterAchievementsAsync(_region, _locale);
        }

        /// <summary>
        ///     Get a list of all of the achievements that characters can earn as well as the category structure and hierarchy.
        /// </summary>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     A list of all of the achievements that characters can earn as well as the category structure and hierarchy.
        /// </returns>
        public async Task<RequestResult<IList<AchievementCategory>>> GetCharacterAchievementsAsync(Region region, Locale locale)
        {
            string host = GetHost(region);
            RequestResult<IList<AchievementCategory>> achievementList = await Get<IList<AchievementCategory>>($"{host}/wow/data/character/achievements?locale={locale}&apikey={_apiKey}", "achievements");
            return achievementList;
        }

        /// <summary>
        ///     Get a list of all supported character classes.
        /// </summary>
        /// <returns>
        ///     A list of all supported character classes.
        /// </returns>
        public async Task<RequestResult<IList<CharacterClassData>>> GetCharacterClassesAsync()
        {
            return await GetCharacterClassesAsync(_region, _locale);
        }

        /// <summary>
        /// Get a list of all supported character classes.
        /// </summary>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        /// A list of all supported character classes.
        /// </returns>
        public async Task<RequestResult<IList<CharacterClassData>>> GetCharacterClassesAsync(Region region, Locale locale)
        {
            string host = GetHost(region);
            RequestResult<IList<CharacterClassData>> characterClassList = await Get<IList<CharacterClassData>>($"{host}/wow/data/character/classes?locale={locale}&apikey={_apiKey}", "classes");
            return characterClassList;
        }

        /// <summary>
        ///     Get a list of all supported character races.
        /// </summary>
        /// <returns>
        ///     A list of all supported character races.
        /// </returns>
        public async Task<RequestResult<IList<CharacterRace>>> GetCharacterRacesAsync()
        {
            return await GetCharacterRacesAsync(_region, _locale);
        }

        /// <summary>
        ///     Get a list of all supported character races.
        /// </summary>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     A list of all supported character races.
        /// </returns>
        public async Task<RequestResult<IList<CharacterRace>>> GetCharacterRacesAsync(Region region, Locale locale)
        {
            string host = GetHost(region);
            RequestResult<IList<CharacterRace>> characterRaceList = await Get<IList<CharacterRace>>($"{host}/wow/data/character/races?locale={locale}&apikey={_apiKey}", "races");
            return characterRaceList;
        }

        /// <summary>
        ///     Get the specified guild.
        /// </summary>
        /// <param name="realm">The realm.</param>
        /// <param name="guildName">The guild name.</param>
        /// <param name="fields">The guild fields to include.</param>
        /// <returns>
        ///     The specified guild.
        /// </returns>
        public async Task<RequestResult<Guild>> GetGuildAsync(string realm, string guildName, GuildFields fields = GuildFields.None)
        {
            return await GetGuildAsync(realm, guildName, _region, _locale, fields);
        }

        /// <summary>
        ///     Get the specified guild.
        /// </summary>
        /// <param name="realm">The realm.</param>
        /// <param name="guildName">The guild name.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <param name="fields">The guild fields to include.</param>
        /// <returns>
        ///     The specified guild.
        /// </returns>
        public async Task<RequestResult<Guild>> GetGuildAsync(string realm, string guildName, Region region, Locale locale, GuildFields fields = GuildFields.None)
        {
            string host = GetHost(region);
            string queryStringFields = fields.BuildQueryString();
            return await Get<Guild>($"{host}/wow/guild/{realm}/{Uri.EscapeUriString(guildName)}?locale={locale}{queryStringFields}&apikey={_apiKey}");
        }

        /// <summary>
        ///     Get a list of all guild achievements.
        /// </summary>
        /// <returns>
        ///     A list of all guild achievements.
        /// </returns>
        public async Task<RequestResult<IList<AchievementCategory>>> GetGuildAchievementsAsync()
        {
            return await GetGuildAchievementsAsync(_region, _locale);
        }

        /// <summary>
        ///     Get a list of all guild achievements.
        /// </summary>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     A list of all guild achievements.
        /// </returns>
        public async Task<RequestResult<IList<AchievementCategory>>> GetGuildAchievementsAsync(Region region, Locale locale)
        {
            string host = GetHost(region);
            RequestResult<IList<AchievementCategory>> guildAchievementsList = await Get<IList<AchievementCategory>>($"{host}/wow/data/guild/achievements?locale={locale}&apikey={_apiKey}", "achievements");
            return guildAchievementsList;
        }

        /// <summary>
        ///     Get a list of all guild perks.
        /// </summary>
        /// <returns>
        ///     A list of all guild perks.
        /// </returns>
        public async Task<RequestResult<IList<Perk>>> GetGuildPerksAsync()
        {
            return await GetGuildPerksAsync(_region, _locale);
        }

        /// <summary>
        ///     Get a list of all guild perks.
        /// </summary>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     A list of all guild perks.
        /// </returns>
        public async Task<RequestResult<IList<Perk>>> GetGuildPerksAsync(Region region, Locale locale)
        {
            string host = GetHost(region);
            RequestResult<IList<Perk>> guildPerksList = await Get<IList<Perk>>($"{host}/wow/data/guild/perks?locale={locale}&apikey={_apiKey}", "perks");
            return guildPerksList;
        }

        /// <summary>
        ///     Get a list of all guild rewards.
        /// </summary>
        /// <returns>
        ///     A list of all guild rewards.
        /// </returns>
        public async Task<RequestResult<IList<Reward>>> GetGuildRewardsAsync()
        {
            return await GetGuildRewardsAsync(_region, _locale);
        }

        /// <summary>
        ///     Get a list of all guild rewards.
        /// </summary>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     A list of all guild rewards.
        /// </returns>
        public async Task<RequestResult<IList<Reward>>> GetGuildRewardsAsync(Region region, Locale locale)
        {
            string host = GetHost(region);
            RequestResult<IList<Reward>> guildRewardsList = await Get<IList<Reward>>($"{host}/wow/data/guild/rewards?locale={locale}&apikey={_apiKey}", "rewards");
            return guildRewardsList;
        }

        /// <summary>
        ///     Get the specified item.
        /// </summary>
        /// <param name="itemId">The item ID.</param>
        /// <returns>
        ///     The specified item.
        /// </returns>
        public async Task<RequestResult<Item>> GetItemAsync(int itemId)
        {
            return await GetItemAsync(itemId, _region, _locale);
        }

        /// <summary>
        ///     Get the specified item.
        /// </summary>
        /// <param name="itemId">The item ID.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     The specified item.
        /// </returns>
        public async Task<RequestResult<Item>> GetItemAsync(int itemId, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<Item>($"{host}/wow/item/{itemId}?locale={locale}&apikey={_apiKey}");
        }

        /// <summary>
        ///     Get a list of all item classes.
        /// </summary>
        /// <returns>
        ///     A list of all item classes.
        /// </returns>
        public async Task<RequestResult<IList<ItemClass>>> GetItemClassesAsync()
        {
            return await GetItemClassesAsync(_region, _locale);
        }

        /// <summary>
        ///     Get a list of all item classes.
        /// </summary>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     A list of all item classes.
        /// </returns>
        public async Task<RequestResult<IList<ItemClass>>> GetItemClassesAsync(Region region, Locale locale)
        {
            string host = GetHost(region);
            RequestResult<IList<ItemClass>> itemClassesList = await Get<IList<ItemClass>>($"{host}/wow/data/item/classes?locale={locale}&apikey={_apiKey}", "classes");
            return itemClassesList;
        }

        /// <summary>
        ///     Get the specified item set.
        /// </summary>
        /// <param name="itemSetId">The item set ID.</param>
        /// <returns>
        ///     The specified item set.
        /// </returns>
        public async Task<RequestResult<ItemSet>> GetItemSetAsync(int itemSetId)
        {
            return await GetItemSetAsync(itemSetId, _region, _locale);
        }

        /// <summary>
        ///     Get the specified item set.
        /// </summary>
        /// <param name="itemSetId">The item set ID.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     The specified item set.
        /// </returns>
        public async Task<RequestResult<ItemSet>> GetItemSetAsync(int itemSetId, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<ItemSet>($"{host}/wow/item/set/{itemSetId}?locale={locale}&apikey={_apiKey}");
        }

        /// <summary>
        ///     Get a list of all supported mounts.
        /// </summary>
        /// <returns>
        ///     A list of all supported mounts.
        /// </returns>
        public async Task<RequestResult<IList<Mount>>> GetMountsAsync()
        {
            return await GetMountsAsync(_region, _locale);
        }

        /// <summary>
        ///     Get a list of all supported mounts.
        /// </summary>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     A list of all supported mounts.
        /// </returns>
        public async Task<RequestResult<IList<Mount>>> GetMountsAsync(Region region, Locale locale)
        {
            string host = GetHost(region);
            RequestResult<IList<Mount>> mountList = await Get<IList<Mount>>($"{host}/wow/mount/?locale={locale}&apikey={_apiKey}", "mounts");
            return mountList;
        }

        /// <summary>
        ///     Get a list of all supported pets.
        /// </summary>
        /// <returns>
        ///     A list of all supported pets.
        /// </returns>
        public async Task<RequestResult<IList<Pet>>> GetPetsAsync()
        {
            return await GetPetsAsync(_region, _locale);
        }

        /// <summary>
        ///     Get a list of all supported pets.
        /// </summary>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     A list of all supported pets.
        /// </returns>
        public async Task<RequestResult<IList<Pet>>> GetPetsAsync(Region region, Locale locale)
        {
            string host = GetHost(region);
            RequestResult<IList<Pet>> petList = await Get<IList<Pet>>($"{host}/wow/pet/?locale={locale}&apikey={_apiKey}", "pets");
            return petList;
        }

        /// <summary>
        ///     Get the specified pet ability.
        /// </summary>
        /// <param name="abilityId">The pet ability ID.</param>
        /// <returns>
        ///     The specified pet ability.
        /// </returns>
        public async Task<RequestResult<PetAbility>> GetPetAbilityAsync(int abilityId)
        {
            return await GetPetAbilityAsync(abilityId, _region, _locale);
        }

        /// <summary>
        ///     Get the specified pet ability.
        /// </summary>
        /// <param name="abilityId">The pet ability ID.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     The specified pet ability.
        /// </returns>
        public async Task<RequestResult<PetAbility>> GetPetAbilityAsync(int abilityId, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<PetAbility>($"{host}/wow/pet/ability/{abilityId}?locale={locale}&apikey={_apiKey}");
        }

        /// <summary>
        ///     Get the specified pet species.
        /// </summary>
        /// <param name="speciesId">The pet species ID.</param>
        /// <returns>
        ///     The specified pet species.
        /// </returns>
        public async Task<RequestResult<PetSpecies>> GetPetSpeciesAsync(int speciesId)
        {
            return await GetPetSpeciesAsync(speciesId, _region, _locale);
        }

        /// <summary>
        ///     Get the specified pet species.
        /// </summary>
        /// <param name="speciesId">The pet species ID.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     The specified pet species.
        /// </returns>
        public async Task<RequestResult<PetSpecies>> GetPetSpeciesAsync(int speciesId, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<PetSpecies>($"{host}/wow/pet/species/{speciesId}?locale={locale}&apikey={_apiKey}");
        }

        /// <summary>
        ///     Get the pet stats for the specified pet species, level, breed, and quality.
        /// </summary>
        /// <param name="speciesId">The pet species ID.</param>
        /// <param name="level">The pet level.</param>
        /// <param name="breedId">The breed ID.</param>
        /// <param name="quality">The quality.</param>
        /// <returns>
        ///     The pet stats for the specified pet species, level, breed, and quality.
        /// </returns>
        public async Task<RequestResult<PetStats>> GetPetStatsAsync(int speciesId, int level, int breedId, BattlePetQuality quality)
        {
            return await GetPetStatsAsync(speciesId, level, breedId, quality, _region, _locale);
        }

        /// <summary>
        ///     Get the pet stats for the specified pet species, level, breed, and quality.
        /// </summary>
        /// <param name="speciesId">The pet species ID.</param>
        /// <param name="level">The pet level.</param>
        /// <param name="breedId">The breed ID.</param>
        /// <param name="quality">The quality.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     The pet stats for the specified pet species, level, breed, and quality.
        /// </returns>
        public async Task<RequestResult<PetStats>> GetPetStatsAsync(int speciesId, int level, int breedId, BattlePetQuality quality, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<PetStats>($"{host}/wow/pet/stats/{speciesId}?level={level}&breedId={breedId}&qualityId={quality:D}&locale={locale}&apikey={_apiKey}");
        }

        /// <summary>
        ///     Get a list of all pet types.
        /// </summary>
        /// <returns>
        ///     A list of all pet types.
        /// </returns>
        public async Task<RequestResult<IList<PetType>>> GetPetTypesAsync()
        {
            return await GetPetTypesAsync(_region, _locale);
        }

        /// <summary>
        ///     Get a list of all pet types.
        /// </summary>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     A list of all pet types.
        /// </returns>
        public async Task<RequestResult<IList<PetType>>> GetPetTypesAsync(Region region, Locale locale)
        {
            string host = GetHost(region);
            RequestResult<IList<PetType>> petTypeList = await Get<IList<PetType>>($"{host}/wow/data/pet/types?locale={locale}&apikey={_apiKey}", "petTypes");
            return petTypeList;
        }

        /// <summary>
        ///     Get the PvP leaderboard for the specified bracket.
        /// </summary>
        /// <param name="bracket">The PvP leaderboard bracket.  Valid entries are 2v2, 3v3, 5v5, and rbg.</param>
        /// <returns>
        ///     The PvP leaderboard for the specified bracket.
        /// </returns>
        public async Task<RequestResult<PvpLeaderboard>> GetPvpLeaderboardAsync(string bracket)
        {
            return await GetPvpLeaderboardAsync(bracket, _region, _locale);
        }

        /// <summary>
        ///     Get the PvP leaderboard for the specified bracket.
        /// </summary>
        /// <param name="bracket">The PvP leaderboard bracket.  Valid entries are 2v2, 3v3, 5v5, and rbg.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     The PvP leaderboard for the specified bracket.
        /// </returns>
        public async Task<RequestResult<PvpLeaderboard>> GetPvpLeaderboardAsync(string bracket, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<PvpLeaderboard>($"{host}/wow/leaderboard/{bracket}?locale={locale}&apikey={_apiKey}");
        }

        /// <summary>
        ///     Get the specified quest.
        /// </summary>
        /// <param name="questId">The quest ID.</param>
        /// <returns>
        ///     The specified quest.
        /// </returns>
        public async Task<RequestResult<Quest>> GetQuestAsync(int questId)
        {
            return await GetQuestAsync(questId, _region, _locale);
        }

        /// <summary>
        ///     Get the specified quest.
        /// </summary>
        /// <param name="questId">The quest ID.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     The specified quest.
        /// </returns>
        public async Task<RequestResult<Quest>> GetQuestAsync(int questId, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<Quest>($"{host}/wow/quest/{questId}?locale={locale}&apikey={_apiKey}");
        }

        /// <summary>
        ///     Get the statuses for all realms.
        /// </summary>
        /// <returns>
        ///     The statuses for all realms.
        /// </returns>
        public async Task<RequestResult<IList<Realm>>> GetRealmStatusAsync()
        {
            return await GetRealmStatusAsync(_region, _locale);
        }

        /// <summary>
        ///     Get the statuses for all realms.
        /// </summary>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     The statuses for all realms.
        /// </returns>
        public async Task<RequestResult<IList<Realm>>> GetRealmStatusAsync(Region region, Locale locale)
        {
            string host = GetHost(region);
            RequestResult<IList<Realm>> realmList = await Get<IList<Realm>>($"{host}/wow/realm/status?locale={locale}&apikey={_apiKey}", "realms");
            return realmList;
        }

        /// <summary>
        ///     Get the specified recipe.
        /// </summary>
        /// <param name="recipeId">The recipe ID.</param>
        /// <returns>
        ///     The specified recipe.
        /// </returns>
        public async Task<RequestResult<Recipe>> GetRecipeAsync(int recipeId)
        {
            return await GetRecipeAsync(recipeId, _region, _locale);
        }

        /// <summary>
        ///     Get the specified recipe.
        /// </summary>
        /// <param name="recipeId">The recipe ID.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     The specified recipe.
        /// </returns>
        public async Task<RequestResult<Recipe>> GetRecipeAsync(int recipeId, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<Recipe>($"{host}/wow/recipe/{recipeId}?locale={locale}&apikey={_apiKey}");
        }

        /// <summary>
        ///     Get the specified spell.
        /// </summary>
        /// <param name="spellId">The spell ID.</param>
        /// <returns>
        ///     The specified spell.
        /// </returns>
        public async Task<RequestResult<Spell>> GetSpellAsync(int spellId)
        {
            return await GetSpellAsync(spellId, _region, _locale);
        }

        /// <summary>
        ///     Get the specified spell.
        /// </summary>
        /// <param name="spellId">The spell ID.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     The specified spell.
        /// </returns>
        public async Task<RequestResult<Spell>> GetSpellAsync(int spellId, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<Spell>($"{host}/wow/spell/{spellId}?locale={locale}&apikey={_apiKey}");
        }

        /// <summary>
        ///     Get a dictionary of talents, indexed by character class.
        /// </summary>
        /// <returns>
        ///     A dictionary of talents, indexed by character class.
        /// </returns>
        public async Task<RequestResult<IDictionary<CharacterClass, TalentSet>>> GetTalentsAsync()
        {
            return await GetTalentsAsync(_region, _locale);
        }

        /// <summary>
        ///     Get a dictionary of talents, indexed by character class.
        /// </summary>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     A dictionary of talents, indexed by character class.
        /// </returns>
        public async Task<RequestResult<IDictionary<CharacterClass, TalentSet>>> GetTalentsAsync(Region region, Locale locale)
        {
            string host = GetHost(region);
            RequestResult<IDictionary<CharacterClass, TalentSet>> talents = await Get<IDictionary<CharacterClass, TalentSet>>($"{host}/wow/data/talents?locale={locale}&apikey={_apiKey}");
            return talents;
        }

        /// <summary>
        ///     Get the specified zone.
        /// </summary>
        /// <param name="zoneId">The zone ID.</param>
        /// <returns>
        ///     The specified zone.
        /// </returns>
        public async Task<RequestResult<Zone>> GetZoneAsync(int zoneId)
        {
            return await GetZoneAsync(zoneId, _region, _locale);
        }

        /// <summary>
        ///     Get the specified zone.
        /// </summary>
        /// <param name="zoneId">The zone ID.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     The specified zone.
        /// </returns>
        public async Task<RequestResult<Zone>> GetZoneAsync(int zoneId, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<Zone>($"{host}/wow/zone/{zoneId}?locale={locale}&apikey={_apiKey}");
        }

        /// <summary>
        ///     Get a list of all supported zones.
        /// </summary>
        /// <returns>
        ///     A list of all supported zones.
        /// </returns>
        public async Task<RequestResult<IList<Zone>>> GetZonesAsync()
        {
            return await GetZonesAsync(_region, _locale);
        }

        /// <summary>
        ///     Get a list of all supported zones.
        /// </summary>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     A list of all supported zones.
        /// </returns>
        public async Task<RequestResult<IList<Zone>>> GetZonesAsync(Region region, Locale locale)
        {
            string host = GetHost(region);
            RequestResult<IList<Zone>> zoneList = await Get<IList<Zone>>($"{host}/wow/zone/?locale={locale}&apikey={_apiKey}", "zones");
            return zoneList;
        }

        /// <summary>
        ///     Retrieve an item of type <typeparamref name="T"/> from the Blizzard Community API.
        /// </summary>
        /// <typeparam name="T">
        ///     The return type.
        /// </typeparam>
        /// <param name="requestUri">
        ///     The URI the request is sent to.
        /// </param>
        /// <param name="arrayName">
        ///     The name of the array to deserialize. This is used to avoid using a root object for JSON arrays.
        /// </param>
        /// <returns>
        ///     The JSON response, deserialized to an object of type <typeparamref name="T"/>.
        /// </returns>
        private async Task<RequestResult<T>> Get<T>(string requestUri, string arrayName = null)
        {
            // Retrieve the response.
            HttpResponseMessage response = await _client.GetAsync(requestUri).ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
            {
                // Check if the request was successful and made it to the Blizzard API.
                // The API will always send back content if successful.
                if (response.Content != null)
                {
                    string content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    RequestResult<T> requestError = JsonConvert.DeserializeObject<RequestError>(content);

                    return requestError;
                }

                // If not then it is most likely a problem on our end due to an HTTP error.
                string safeUri = requestUri.Replace(_apiKey, "{apiKey}");
                string message = $"Response code {(int)response.StatusCode} ({response.ReasonPhrase}) does not indicate success. Request: {safeUri}";

                throw new HttpRequestException(message);
            }

            // Deserialize an object of type T from the JSON string.
            string json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            if (arrayName != null)
            {
                json = JObject.Parse(json).SelectToken(arrayName).ToString();
            }

            RequestResult<T> requestResult = JsonConvert.DeserializeObject<T>(json, new JsonSerializerSettings
            {
                ContractResolver = new ArgentPonyWarcraftClientContractResolver(),
#if DEBUG
                MissingMemberHandling = MissingMemberHandling.Error
#else
                MissingMemberHandling = MissingMemberHandling.Ignore
#endif
            });

            return requestResult;
        }

        /// <summary>
        ///     Get the host for the specified region.
        /// </summary>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <returns>
        ///     The host for the specified region.
        /// </returns>
        private static string GetHost(Region region)
        {
            switch (region)
            {
                case Region.China:
                    return "https://www.battlenet.com.cn";
                case Region.Europe:
                    return "https://eu.api.battle.net";
                case Region.Korea:
                    return "https://kr.api.battle.net";
                case Region.Taiwan:
                    return "https://tw.api.battle.net";
                case Region.US:
                default:
                    return "https://us.api.battle.net";
            }
        }

        /// <summary>
        ///     Checks if the locale is supported by the selected region.
        /// </summary>
        /// <param name="locale">The selected locale.</param>
        /// <param name="region">The selected region.</param>
        /// <returns>Returns true if the locale is supported by the selected region.</returns>
        private static bool ValidateRegionLocale(Locale locale, Region region)
        {
            FieldInfo type = locale.GetType().GetRuntimeField(locale.ToString());
            LocaleRegion attribute = type.GetCustomAttribute<LocaleRegion>();

            return attribute.Region == region;
        }
    }
}