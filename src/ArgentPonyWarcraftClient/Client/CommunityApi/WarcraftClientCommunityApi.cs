using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Community;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    ///     A client for the World of Warcraft Community APIs.
    /// </summary>
    public partial class WarcraftClient
    {
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
            return await Get<Achievement>(region, $"{host}/wow/achievement/{id}?locale={locale}");
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
            return await Get<AuctionFiles>(region, $"{host}/wow/auction/data/{realm}?locale={locale}");
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
            // TODO: Need to extract the region from the URL or add it to the method signature.
            return await Get<AuctionHouseSnapshot>(Region.US, url);
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
            return await Get<Boss>(region, $"{host}/wow/boss/{id}?locale={locale}");
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
            RequestResult<IList<Boss>> bossList = await Get<IList<Boss>>(region, $"{host}/wow/boss/?locale={locale}", "bosses");
            return bossList;
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
            RequestResult<IList<Challenge>> challengeList = await Get<IList<Challenge>>(region, $"{host}/wow/challenge/{realm}?locale={locale}", "challenge");
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
            return await Get<Character>(region, $"{host}/wow/character/{realm}/{characterName}?&locale={locale}{queryStringFields}");
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
            RequestResult<IList<AchievementCategory>> achievementList = await Get<IList<AchievementCategory>>(region, $"{host}/wow/data/character/achievements?locale={locale}", "achievements");
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
            RequestResult<IList<CharacterClassData>> characterClassList = await Get<IList<CharacterClassData>>(region, $"{host}/wow/data/character/classes?locale={locale}", "classes");
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
            RequestResult<IList<CharacterRace>> characterRaceList = await Get<IList<CharacterRace>>(region, $"{host}/wow/data/character/races?locale={locale}", "races");
            return characterRaceList;
        }

        /// <summary>
        ///     Get the characters for a user account.
        /// </summary>
        /// <param name="accessToken">An OAuth access token for the user.</param>
        /// <returns>
        ///     The characters for a user account.
        /// </returns>
        public async Task<RequestResult<IList<GuildCharacter>>> GetCharactersAsync(string accessToken)
        {
            return await GetCharactersAsync(accessToken, _region);
        }

        /// <summary>
        ///     Get the characters for a user account.
        /// </summary>
        /// <param name="accessToken">An OAuth access token for the user.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <returns>
        ///     The characters for a user account.
        /// </returns>
        public async Task<RequestResult<IList<GuildCharacter>>> GetCharactersAsync(string accessToken, Region region)
        {
            string host = GetHost(region);
            RequestResult<IList<GuildCharacter>> characters = await Get<IList<GuildCharacter>>(region, $"{host}/wow/user/characters?access_token={accessToken}", "characters");
            return characters;
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
            return await Get<Guild>(region, $"{host}/wow/guild/{realm}/{Uri.EscapeUriString(guildName)}?locale={locale}{queryStringFields}");
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
            RequestResult<IList<AchievementCategory>> guildAchievementsList = await Get<IList<AchievementCategory>>(region, $"{host}/wow/data/guild/achievements?locale={locale}", "achievements");
            return guildAchievementsList;
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
            return await Get<Item>(region, $"{host}/wow/item/{itemId}?locale={locale}");
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
            RequestResult<IList<ItemClass>> itemClassesList = await Get<IList<ItemClass>>(region, $"{host}/wow/data/item/classes?locale={locale}", "classes");
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
            return await Get<ItemSet>(region, $"{host}/wow/item/set/{itemSetId}?locale={locale}");
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
            RequestResult<IList<Mount>> mountList = await Get<IList<Mount>>(region, $"{host}/wow/mount/?locale={locale}", "mounts");
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
            RequestResult<IList<Pet>> petList = await Get<IList<Pet>>(region, $"{host}/wow/pet/?locale={locale}", "pets");
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
            return await Get<PetAbility>(region, $"{host}/wow/pet/ability/{abilityId}?locale={locale}");
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
            return await Get<PetSpecies>(region, $"{host}/wow/pet/species/{speciesId}?locale={locale}");
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
            return await Get<PetStats>(region, $"{host}/wow/pet/stats/{speciesId}?level={level}&breedId={breedId}&qualityId={quality:D}&locale={locale}");
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
            RequestResult<IList<PetType>> petTypeList = await Get<IList<PetType>>(region, $"{host}/wow/data/pet/types?locale={locale}", "petTypes");
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
            return await Get<PvpLeaderboard>(region, $"{host}/wow/leaderboard/{bracket}?locale={locale}");
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
            return await Get<Quest>(region, $"{host}/wow/quest/{questId}?locale={locale}");
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
            RequestResult<IList<Realm>> realmList = await Get<IList<Realm>>(region, $"{host}/wow/realm/status?locale={locale}", "realms");
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
            return await Get<Recipe>(region, $"{host}/wow/recipe/{recipeId}?locale={locale}");
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
            return await Get<Spell>(region, $"{host}/wow/spell/{spellId}?locale={locale}");
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
            RequestResult<IDictionary<CharacterClass, TalentSet>> talents = await Get<IDictionary<CharacterClass, TalentSet>>(region, $"{host}/wow/data/talents?locale={locale}");
            return talents;
        }

        /// <summary>
        ///     Get user account details.
        /// </summary>
        /// <param name="accessToken">An OAuth access token for the user.</param>
        /// <returns>
        ///     User account details.
        /// </returns>
        public async Task<RequestResult<UserAccount>> GetUserAsync(string accessToken)
        {
            return await GetUserAsync(accessToken, _region);
        }

        /// <summary>
        ///     Get user account details.
        /// </summary>
        /// <param name="accessToken">An OAuth access token for the user.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <returns>
        ///     User account details.
        /// </returns>
        public async Task<RequestResult<UserAccount>> GetUserAsync(string accessToken, Region region)
        {
            string host = GetHost(region);
            RequestResult<UserAccount> userAccount = await Get<UserAccount>(region, $"{host}/account/user?access_token={accessToken}");
            return userAccount;
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
            return await Get<Zone>(region, $"{host}/wow/zone/{zoneId}?locale={locale}");
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
            RequestResult<IList<Zone>> zoneList = await Get<IList<Zone>>(region, $"{host}/wow/zone/?locale={locale}", "zones");
            return zoneList;
        }
    }
}
