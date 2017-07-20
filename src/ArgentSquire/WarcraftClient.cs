using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// A client for the World of Warcraft Community APIs.
    /// </summary>
    public class WarcraftClient
    {
        /// <summary>
        /// The API key.
        /// </summary>
        private readonly string _apiKey;

        /// <summary>
        /// The region.
        /// </summary>
        private readonly Region _region;

        /// <summary>
        /// The locale.
        /// </summary>
        private readonly string _locale;

        /// <summary>
        /// Initializes a new instance of the <see cref="WarcraftClient"/> class.
        /// </summary>
        /// <remarks>
        /// Defaults the region to US and the locale to "en_US".
        /// </remarks>
        /// <param name="apiKey">The API key.</param>
        public WarcraftClient(string apiKey)
            : this(apiKey, Region.US, "en_US")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WarcraftClient"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <param name="region">The region.</param>
        /// <param name="locale">The locale.</param>
        public WarcraftClient(string apiKey, Region region, string locale)
        {
            _apiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
            _region = region;
            _locale = locale;
        }

        /// <summary>
        /// Get the specified achievement.
        /// </summary>
        /// <param name="id">The achievement ID.</param>
        /// <returns>
        /// The specified achievement.
        /// </returns>
        public async Task<Achievement> GetAchievementAsync(int id)
        {
            return await GetAchievementAsync(id, _region, _locale);
        }

        /// <summary>
        /// Get the specified achievement.
        /// </summary>
        /// <param name="id">The achievement ID.</param>
        /// <param name="region">The region.</param>
        /// <param name="locale">The locale.</param>
        /// <returns>
        /// The specified achievement.
        /// </returns>
        public async Task<Achievement> GetAchievementAsync(int id, Region region, string locale)
        {
            string host = GetHost(region);
            return await Get<Achievement>($"{host}/wow/achievement/{id}?locale={locale}&apikey={_apiKey}");
        }

        /// <summary>
        /// Get the specified auction.
        /// </summary>
        /// <param name="realm">The realm.</param>
        /// <returns>
        /// The specified auction.
        /// </returns>
        public async Task<AuctionFiles> GetAuctionAsync(string realm)
        {
            return await GetAuctionAsync(realm, _region, _locale);
        }

        /// <summary>
        /// Get the specified auction.
        /// </summary>
        /// <param name="realm">The realm.</param>
        /// <param name="region">The region.</param>
        /// <param name="locale">The locale.</param>
        /// <returns>
        /// The specified auction.
        /// </returns>
        public async Task<AuctionFiles> GetAuctionAsync(string realm, Region region, string locale)
        {
            string host = GetHost(region);
            return await Get<AuctionFiles>($"{host}/wow/auction/data/{realm}?locale={locale}&apikey={_apiKey}");
        }

        /// <summary>
        /// Get the auction house snapshot from the specified file.
        /// </summary>
        /// <param name="url">The URL for the auction house file.</param>
        /// <returns>
        /// The auction house snapshot from the specified file.
        /// </returns>
        public async Task<AuctionHouseSnapshot> GetAuctionHouseSnapshotAsync(string url)
        {
            return await Get<AuctionHouseSnapshot>(url);
        }

        /// <summary>
        /// Get a list of all supported battlegroups.
        /// </summary>
        /// <returns>
        /// A list of all supported battlegroups.
        /// </returns>
        public async Task<IList<Battlegroup>> GetBattlegroupsAsync()
        {
            return await GetBattlegroupsAsync(_region, _locale);
        }

        /// <summary>
        /// Get a list of all supported battlegroups.
        /// </summary>
        /// <param name="region">The region.</param>
        /// <param name="locale">The locale.</param>
        /// <returns>
        /// A list of all supported battlegroups.
        /// </returns>
        public async Task<IList<Battlegroup>> GetBattlegroupsAsync(Region region, string locale)
        {
            string host = GetHost(region);
            BattlegroupList battlegroupList = await Get<BattlegroupList>($"{host}/wow/data/battlegroups/?locale={locale}&apikey={_apiKey}");
            return battlegroupList.Battlegroups;
        }

        /// <summary>
        /// Get the specified boss.
        /// </summary>
        /// <remarks>
        /// A "boss" in this context should be considered a boss encounter, which may include more than one NPC.
        /// </remarks>
        /// <param name="id">The boss ID.</param>
        /// <returns>
        /// The specified boss.
        /// </returns>
        public async Task<Boss> GetBossAsync(int id)
        {
            return await GetBossAsync(id, _region, _locale);
        }

        /// <summary>
        /// Get the specified boss.
        /// </summary>
        /// <remarks>
        /// A "boss" in this context should be considered a boss encounter, which may include more than one NPC.
        /// </remarks>
        /// <param name="id">The boss ID.</param>
        /// <param name="region">The region.</param>
        /// <param name="locale">The locale.</param>
        /// <returns>
        /// The specified boss.
        /// </returns>
        public async Task<Boss> GetBossAsync(int id, Region region, string locale)
        {
            string host = GetHost(region);
            return await Get<Boss>($"{host}/wow/boss/{id}?locale={locale}&apikey={_apiKey}");
        }

        /// <summary>
        /// Get a list of all supported bosses.
        /// </summary>
        /// <remarks>
        /// A "boss" in this context should be considered a boss encounter, which may include more than one NPC.
        /// </remarks>
        /// <returns>
        /// A list of all supported bosses.
        /// </returns>
        public async Task<List<Boss>> GetBossesAsync()
        {
            return await GetBossesAsync(_region, _locale);
        }

        /// <summary>
        /// Get a list of all supported bosses.
        /// </summary>
        /// <remarks>
        /// A "boss" in this context should be considered a boss encounter, which may include more than one NPC.
        /// </remarks>
        /// <param name="region">The region.</param>
        /// <param name="locale">The locale.</param>
        /// <returns>
        /// A list of all supported bosses.
        /// </returns>
        public async Task<List<Boss>> GetBossesAsync(Region region, string locale)
        {
            string host = GetHost(region);
            BossList bossList = await Get<BossList>($"{host}/wow/boss/?locale={locale}&apikey={_apiKey}");
            return bossList.Bosses;
        }

        /// <summary>
        /// Get the challenge mode data for the entire region.
        /// </summary>
        /// <returns>
        /// The challenge mode data for the entire region.
        /// </returns>
        public async Task<IList<Challenge>> GetChallengesAsync()
        {
            return await GetChallengesAsync(_region, _locale);
        }

        /// <summary>
        /// Get the challenge mode data for the entire region.
        /// </summary>
        /// <param name="region">The region.</param>
        /// <param name="locale">The locale.</param>
        /// <returns>
        /// The challenge mode data for the entire region.
        /// </returns>
        public async Task<IList<Challenge>> GetChallengesAsync(Region region, string locale)
        {
            string host = GetHost(region);
            ChallengeList challengeList = await Get<ChallengeList>($"{host}/wow/challenge/region?locale={locale}&apikey={_apiKey}");
            return challengeList.Challenges;
        }

        /// <summary>
        /// Get the challenge mode data for the specified realm.
        /// </summary>
        /// <param name="realm">The realm.</param>
        /// <returns>
        /// The challenge mode data for the specified realm.
        /// </returns>
        public async Task<IList<Challenge>> GetChallengesAsync(string realm)
        {
            return await GetChallengesAsync(realm, _region, _locale);
        }

        /// <summary>
        /// Get the challenge mode data for the specified realm.
        /// </summary>
        /// <param name="realm">The realm.</param>
        /// <param name="region">The region.</param>
        /// <param name="locale">The locale.</param>
        /// <returns>
        /// The challenge mode data for the specified realm.
        /// </returns>
        public async Task<IList<Challenge>> GetChallengesAsync(string realm, Region region, string locale)
        {
            string host = GetHost(region);
            ChallengeList challengeList = await Get<ChallengeList>($"{host}/wow/challenge/{realm}?locale={locale}&apikey={_apiKey}");
            return challengeList.Challenges;
        }

        /// <summary>
        /// Get the specified character.
        /// </summary>
        /// <param name="realm">The realm.</param>
        /// <param name="characterName">The character name.</param>
        /// <param name="fields">The character fields to include.</param>
        /// <returns>
        /// The specified character.
        /// </returns>
        public async Task<Character> GetCharacterAsync(string realm, string characterName, CharacterFields fields = CharacterFields.None)
        {
            return await GetCharacterAsync(realm, characterName, _region, _locale, fields);
        }

        /// <summary>
        /// Get the specified character.
        /// </summary>
        /// <param name="realm">The realm.</param>
        /// <param name="characterName">The character name.</param>
        /// <param name="region">The region.</param>
        /// <param name="locale">The locale.</param>
        /// <param name="fields">The character fields to include.</param>
        /// <returns>
        /// The specified character.
        /// </returns>
        public async Task<Character> GetCharacterAsync(string realm, string characterName, Region region, string locale, CharacterFields fields = CharacterFields.None)
        {
            string host = GetHost(region);
            string queryStringFields = CharacterFieldBuilder.BuildQueryString(fields);
            return await Get<Character>($"{host}/wow/character/{realm}/{characterName}?&locale={locale}{queryStringFields}&apikey={_apiKey}");
        }

        /// <summary>
        /// Get a list of all supported character races.
        /// </summary>
        /// <returns>
        /// A list of all supported character races.
        /// </returns>
        public async Task<IList<CharacterRace>> GetCharacterRacesAsync()
        {
            return await GetCharacterRacesAsync(_region, _locale);
        }

        /// <summary>
        /// Get a list of all supported character races.
        /// </summary>
        /// <param name="region">The region.</param>
        /// <param name="locale">The locale.</param>
        /// <returns>
        /// A list of all supported character races.
        /// </returns>
        public async Task<IList<CharacterRace>> GetCharacterRacesAsync(Region region, string locale)
        {
            string host = GetHost(region);
            CharacterRaceList characterRaceList = await Get<CharacterRaceList>($"{host}/wow/data/character/races?locale={locale}&apikey={_apiKey}");
            return characterRaceList.Races;
        }

        /// <summary>
        /// Get the specified guild.
        /// </summary>
        /// <param name="realm">The realm.</param>
        /// <param name="guildName">The guild name.</param>
        /// <param name="fields">The guild fields to include.</param>
        /// <returns>
        /// The specified guild.
        /// </returns>
        public async Task<Guild> GetGuildAsync(string realm, string guildName, GuildFields fields = GuildFields.None)
        {
            return await GetGuildAsync(realm, guildName, _region, _locale, fields);
        }

        /// <summary>
        /// Get the specified guild.
        /// </summary>
        /// <param name="realm">The realm.</param>
        /// <param name="guildName">The guild name.</param>
        /// <param name="region">The region.</param>
        /// <param name="locale">The locale.</param>
        /// <param name="fields">The guild fields to include.</param>
        /// <returns>
        /// The specified guild.
        /// </returns>
        public async Task<Guild> GetGuildAsync(string realm, string guildName, Region region, string locale, GuildFields fields = GuildFields.None)
        {
            string host = GetHost(region);
            string queryStringFields = GuildFieldBuilder.BuildQueryString(fields);
            return await Get<Guild>($"{host}/wow/guild/{realm}/{Uri.EscapeUriString(guildName)}?locale={locale}{queryStringFields}&apikey={_apiKey}");
        }

        /// <summary>
        /// Get the specified item.
        /// </summary>
        /// <param name="itemId">The item ID.</param>
        /// <returns>
        /// The specified item.
        /// </returns>
        public async Task<Item> GetItemAsync(int itemId)
        {
            return await GetItemAsync(itemId, _region, _locale);
        }

        /// <summary>
        /// Get the specified item.
        /// </summary>
        /// <param name="itemId">The item ID.</param>
        /// <param name="region">The region.</param>
        /// <param name="locale">The locale.</param>
        /// <returns>
        /// The specified item.
        /// </returns>
        public async Task<Item> GetItemAsync(int itemId, Region region, string locale)
        {
            string host = GetHost(region);
            return await Get<Item>($"{host}/wow/item/{itemId}?locale={locale}&apikey={_apiKey}");
        }

        /// <summary>
        /// Get the specified item set.
        /// </summary>
        /// <param name="itemSetId">The item set ID.</param>
        /// <returns>
        /// The specified item set.
        /// </returns>
        public async Task<ItemSet> GetItemSetAsync(int itemSetId)
        {
            return await GetItemSetAsync(itemSetId, _region, _locale);
        }

        /// <summary>
        /// Get the specified item set.
        /// </summary>
        /// <param name="itemSetId">The item set ID.</param>
        /// <param name="region">The region.</param>
        /// <param name="locale">The locale.</param>
        /// <returns>
        /// The specified item set.
        /// </returns>
        public async Task<ItemSet> GetItemSetAsync(int itemSetId, Region region, string locale)
        {
            string host = GetHost(region);
            return await Get<ItemSet>($"{host}/wow/item/set/{itemSetId}?locale={locale}&apikey={_apiKey}");
        }

        /// <summary>
        /// Get a list of all supported mounts.
        /// </summary>
        /// <returns>
        /// A list of all supported mounts.
        /// </returns>
        public async Task<IList<Mount>> GetMountsAsync()
        {
            return await GetMountsAsync(_region, _locale);
        }

        /// <summary>
        /// Get a list of all supported mounts.
        /// </summary>
        /// <param name="region">The region.</param>
        /// <param name="locale">The locale.</param>
        /// <returns>
        /// A list of all supported mounts.
        /// </returns>
        public async Task<IList<Mount>> GetMountsAsync(Region region, string locale)
        {
            string host = GetHost(region);
            MountList mountList = await Get<MountList>($"{host}/wow/mount/?locale={locale}&apikey={_apiKey}");
            return mountList.Mounts;
        }

        /// <summary>
        /// Get a list of all supported pets.
        /// </summary>
        /// <returns>
        /// A list of all supported pets.
        /// </returns>
        public async Task<IList<Pet>> GetPetsAsync()
        {
            return await GetPetsAsync(_region, _locale);
        }

        /// <summary>
        /// Get a list of all supported pets.
        /// </summary>
        /// <param name="region">The region.</param>
        /// <param name="locale">The locale.</param>
        /// <returns>
        /// A list of all supported pets.
        /// </returns>
        public async Task<IList<Pet>> GetPetsAsync(Region region, string locale)
        {
            string host = GetHost(region);
            PetList petList = await Get<PetList>($"{host}/wow/pet/?locale={locale}&apikey={_apiKey}");
            return petList.Pets;
        }

        /// <summary>
        /// Get the specified pet ability.
        /// </summary>
        /// <param name="abilityId">The pet ability ID.</param>
        /// <returns>
        /// The specified pet ability.
        /// </returns>
        public async Task<PetAbility> GetPetAbilityAsync(int abilityId)
        {
            return await GetPetAbilityAsync(abilityId, _region, _locale);
        }

        /// <summary>
        /// Get the specified pet ability.
        /// </summary>
        /// <param name="abilityId">The pet ability ID.</param>
        /// <param name="region">The region.</param>
        /// <param name="locale">The locale.</param>
        /// <returns>
        /// The specified pet ability.
        /// </returns>
        public async Task<PetAbility> GetPetAbilityAsync(int abilityId, Region region, string locale)
        {
            string host = GetHost(region);
            return await Get<PetAbility>($"{host}/wow/pet/ability/{abilityId}?locale={locale}&apikey={_apiKey}");
        }

        /// <summary>
        /// Get the specified pet species.
        /// </summary>
        /// <param name="speciesId">The pet species ID.</param>
        /// <returns>
        /// The specified pet species.
        /// </returns>
        public async Task<PetSpecies> GetPetSpeciesAsync(int speciesId)
        {
            return await GetPetSpeciesAsync(speciesId, _region, _locale);
        }

        /// <summary>
        /// Get the specified pet species.
        /// </summary>
        /// <param name="speciesId">The pet species ID.</param>
        /// <param name="region">The region.</param>
        /// <param name="locale">The locale.</param>
        /// <returns>
        /// The specified pet species.
        /// </returns>
        public async Task<PetSpecies> GetPetSpeciesAsync(int speciesId, Region region, string locale)
        {
            string host = GetHost(region);
            return await Get<PetSpecies>($"{host}/wow/pet/species/{speciesId}?locale={locale}&apikey={_apiKey}");
        }

        /// <summary>
        /// Get the pet stats for the specified pet species, level, breed, and quality.
        /// </summary>
        /// <param name="speciesId">The pet species ID.</param>
        /// <param name="level">The pet level.</param>
        /// <param name="breedId">The breed ID.</param>
        /// <param name="quality">The quality.</param>
        /// <returns>
        /// The pet stats for the specified pet species, level, breed, and quality.
        /// </returns>
        public async Task<PetStats> GetPetStatsAsync(int speciesId, int level, int breedId, BattlePetQuality quality)
        {
            return await GetPetStatsAsync(speciesId, level, breedId, quality, _region, _locale);
        }

        /// <summary>
        /// Get the pet stats for the specified pet species, level, breed, and quality.
        /// </summary>
        /// <param name="speciesId">The pet species ID.</param>
        /// <param name="level">The pet level.</param>
        /// <param name="breedId">The breed ID.</param>
        /// <param name="quality">The quality.</param>
        /// <param name="region">The region.</param>
        /// <param name="locale">The locale.</param>
        /// <returns>
        /// The pet stats for the specified pet species, level, breed, and quality.
        /// </returns>
        public async Task<PetStats> GetPetStatsAsync(int speciesId, int level, int breedId, BattlePetQuality quality, Region region, string locale)
        {
            string host = GetHost(region);
            return await Get<PetStats>($"{host}/wow/pet/stats/{speciesId}?level={level}&breedId={breedId}&qualityId={quality:D}&locale={locale}&apikey={_apiKey}");
        }

        /// <summary>
        /// Get the PvP leaderboard for the specified bracket.
        /// </summary>
        /// <param name="bracket">The PvP leaderboard bracket.  Valid entries are 2v2, 3v3, 5v5, and rbg.</param>
        /// <returns>
        /// The PvP leaderboard for the specified bracket.
        /// </returns>
        public async Task<PvpLeaderboard> GetPvpLeaderboardAsync(string bracket)
        {
            return await GetPvpLeaderboardAsync(bracket, _region, _locale);
        }

        /// <summary>
        /// Get the PvP leaderboard for the specified bracket.
        /// </summary>
        /// <param name="bracket">The PvP leaderboard bracket.  Valid entries are 2v2, 3v3, 5v5, and rbg.</param>
        /// <param name="region">The region.</param>
        /// <param name="locale">The locale.</param>
        /// <returns>
        /// The PvP leaderboard for the specified bracket.
        /// </returns>
        public async Task<PvpLeaderboard> GetPvpLeaderboardAsync(string bracket, Region region, string locale)
        {
            string host = GetHost(region);
            return await Get<PvpLeaderboard>($"{host}/wow/leaderboard/{bracket}?locale={locale}&apikey={_apiKey}");
        }

        /// <summary>
        /// Get the specified quest.
        /// </summary>
        /// <param name="questId">The quest ID.</param>
        /// <returns>
        /// The specified quest.
        /// </returns>
        public async Task<Quest> GetQuestAsync(int questId)
        {
            return await GetQuestAsync(questId, _region, _locale);
        }

        /// <summary>
        /// Get the specified quest.
        /// </summary>
        /// <param name="questId">The quest ID.</param>
        /// <param name="region">The region.</param>
        /// <param name="locale">The locale.</param>
        /// <returns>
        /// The specified quest.
        /// </returns>
        public async Task<Quest> GetQuestAsync(int questId, Region region, string locale)
        {
            string host = GetHost(region);
            return await Get<Quest>($"{host}/wow/quest/{questId}?locale={locale}&apikey={_apiKey}");
        }

        /// <summary>
        /// Get the statuses for all realms.
        /// </summary>
        /// <returns>
        /// The statuses for all realms.
        /// </returns>
        public async Task<IList<Realm>> GetRealmStatusAsync()
        {
            return await GetRealmStatusAsync(_region, _locale);
        }

        /// <summary>
        /// Get the statuses for all realms.
        /// </summary>
        /// <param name="region">The region.</param>
        /// <param name="locale">The locale.</param>
        /// <returns>
        /// The statuses for all realms.
        /// </returns>
        public async Task<IList<Realm>> GetRealmStatusAsync(Region region, string locale)
        {
            string host = GetHost(region);
            RealmList realmList = await Get<RealmList>($"{host}/wow/realm/status?locale={locale}&apikey={_apiKey}");
            return realmList.Realms;
        }

        /// <summary>
        /// Get the specified recipe.
        /// </summary>
        /// <param name="recipeId">The recipe ID.</param>
        /// <returns>
        /// The specified recipe.
        /// </returns>
        public async Task<Recipe> GetRecipeAsync(int recipeId)
        {
            return await GetRecipeAsync(recipeId, _region, _locale);
        }

        /// <summary>
        /// Get the specified recipe.
        /// </summary>
        /// <param name="recipeId">The recipe ID.</param>
        /// <param name="region">The region.</param>
        /// <param name="locale">The locale.</param>
        /// <returns>
        /// The specified recipe.
        /// </returns>
        public async Task<Recipe> GetRecipeAsync(int recipeId, Region region, string locale)
        {
            string host = GetHost(region);
            return await Get<Recipe>($"{host}/wow/recipe/{recipeId}?locale={locale}&apikey={_apiKey}");
        }

        /// <summary>
        /// Get the specified spell.
        /// </summary>
        /// <param name="spellId">The spell ID.</param>
        /// <returns>
        /// The specified spell.
        /// </returns>
        public async Task<Spell> GetSpellAsync(int spellId)
        {
            return await GetSpellAsync(spellId, _region, _locale);
        }

        /// <summary>
        /// Get the specified spell.
        /// </summary>
        /// <param name="spellId">The spell ID.</param>
        /// <param name="region">The region.</param>
        /// <param name="locale">The locale.</param>
        /// <returns>
        /// The specified spell.
        /// </returns>
        public async Task<Spell> GetSpellAsync(int spellId, Region region, string locale)
        {
            string host = GetHost(region);
            return await Get<Spell>($"{host}/wow/spell/{spellId}?locale={locale}&apikey={_apiKey}");
        }

        /// <summary>
        /// Get the specified zone.
        /// </summary>
        /// <param name="zoneId">The zone ID.</param>
        /// <returns>
        /// The specified zone.
        /// </returns>
        public async Task<Zone> GetZoneAsync(int zoneId)
        {
            return await GetZoneAsync(zoneId, _region, _locale);
        }

        /// <summary>
        /// Get the specified zone.
        /// </summary>
        /// <param name="zoneId">The zone ID.</param>
        /// <param name="region">The region.</param>
        /// <param name="locale">The locale.</param>
        /// <returns>
        /// The specified zone.
        /// </returns>
        public async Task<Zone> GetZoneAsync(int zoneId, Region region, string locale)
        {
            string host = GetHost(region);
            return await Get<Zone>($"{host}/wow/zone/{zoneId}?locale={locale}&apikey={_apiKey}");
        }

        /// <summary>
        /// Get a list of all supported zones.
        /// </summary>
        /// <returns>
        /// A list of all supported zones.
        /// </returns>
        public async Task<IList<Zone>> GetZonesAsync()
        {
            return await GetZonesAsync(_region, _locale);
        }

        /// <summary>
        /// Get a list of all supported zones.
        /// </summary>
        /// <param name="region">The region.</param>
        /// <param name="locale">The locale.</param>
        /// <returns>
        /// A list of all supported zones.
        /// </returns>
        public async Task<IList<Zone>> GetZonesAsync(Region region, string locale)
        {
            string host = GetHost(region);
            ZoneList zoneList = await Get<ZoneList>($"{host}/wow/zone/?locale={locale}&apikey={_apiKey}");
            return zoneList.Zones;
        }

        /// <summary>
        /// Retrieve an item of type <typeparamref name="T"/> from the Blizzard Community API.
        /// </summary>
        /// <typeparam name="T">
        /// The return type.
        /// </typeparam>
        /// <param name="requestUri">
        /// The URI the request is sent to.
        /// </param>
        /// <returns>
        /// The JSON response, deserialized to an object of type <typeparamref name="T"/>.
        /// </returns>
        private async Task<T> Get<T>(string requestUri)
        {
            // Retrieve the response.  Throw an error if we had a problem.
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync(requestUri);
            response.EnsureSuccessStatusCode();

            // Deserialize an object of type T from the JSON string.
            string json = await response.Content.ReadAsStringAsync();
            T item = JsonConvert.DeserializeObject<T>(json, new JsonSerializerSettings
            {
                ContractResolver = new ArgentSquireContractResolver(),
                MissingMemberHandling = MissingMemberHandling.Error
            });

            return item;
        }

        /// <summary>
        /// Get the host for the specified region.
        /// </summary>
        /// <param name="region">The region.</param>
        /// <returns>
        /// The host for the specified region.
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
    }
}
