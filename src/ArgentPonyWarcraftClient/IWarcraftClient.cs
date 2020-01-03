using System.Collections.Generic;
using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    ///     A client for the World of Warcraft Community APIs.
    /// </summary>
    public interface IWarcraftClient
    {
        /// <summary>
        ///     Get the specified achievement.
        /// </summary>
        /// <param name="id">The achievement ID.</param>
        /// <returns>
        ///     The specified achievement.
        /// </returns>
        Task<RequestResult<Achievement>> GetAchievementAsync(int id);

        /// <summary>
        ///     Get the specified achievement.
        /// </summary>
        /// <param name="id">The achievement ID.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     The specified achievement.
        /// </returns>
        Task<RequestResult<Achievement>> GetAchievementAsync(int id, Region region, Locale locale);

        /// <summary>
        ///     Get the specified auction.
        /// </summary>
        /// <param name="realm">The realm.</param>
        /// <returns>
        ///     The specified auction.
        /// </returns>
        Task<RequestResult<AuctionFiles>> GetAuctionAsync(string realm);

        /// <summary>
        ///     Get the specified auction.
        /// </summary>
        /// <param name="realm">The realm.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     The specified auction.
        /// </returns>
        Task<RequestResult<AuctionFiles>> GetAuctionAsync(string realm, Region region, Locale locale);

        /// <summary>
        ///     Get the auction house snapshot from the specified file.
        /// </summary>
        /// <param name="url">The URL for the auction house file.</param>
        /// <returns>
        ///     The auction house snapshot from the specified file.
        /// </returns>
        Task<RequestResult<AuctionHouseSnapshot>> GetAuctionHouseSnapshotAsync(string url);

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
        Task<RequestResult<Boss>> GetBossAsync(int id);

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
        Task<RequestResult<Boss>> GetBossAsync(int id, Region region, Locale locale);

        /// <summary>
        ///     Get a list of all supported bosses.
        /// </summary>
        /// <remarks>
        ///     A "boss" in this context should be considered a boss encounter, which may include more than one NPC.
        /// </remarks>
        /// <returns>
        ///     A list of all supported bosses.
        /// </returns>
        Task<RequestResult<IList<Boss>>> GetBossesAsync();

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
        Task<RequestResult<IList<Boss>>> GetBossesAsync(Region region, Locale locale);

        /// <summary>
        ///     Get the challenge mode data for the specified realm.
        /// </summary>
        /// <param name="realm">The realm.</param>
        /// <returns>
        ///     The challenge mode data for the specified realm.
        /// </returns>
        Task<RequestResult<IList<Challenge>>> GetChallengesAsync(string realm);

        /// <summary>
        ///     Get the challenge mode data for the specified realm.
        /// </summary>
        /// <param name="realm">The realm.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     The challenge mode data for the specified realm.
        /// </returns>
        Task<RequestResult<IList<Challenge>>> GetChallengesAsync(string realm, Region region, Locale locale);

        /// <summary>
        ///     Get the specified character.
        /// </summary>
        /// <param name="realm">The realm.</param>
        /// <param name="characterName">The character name.</param>
        /// <param name="fields">The character fields to include.</param>
        /// <returns>
        ///     The specified character.
        /// </returns>>
        Task<RequestResult<Character>> GetCharacterAsync(string realm, string characterName, CharacterFields fields = CharacterFields.None);

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
        Task<RequestResult<Character>> GetCharacterAsync(string realm, string characterName, Region region, Locale locale, CharacterFields fields = CharacterFields.None);

        /// <summary>
        ///     Get a list of all of the achievements that characters can earn as well as the category structure and hierarchy.
        /// </summary>
        /// <returns>
        ///     A list of all of the achievements that characters can earn as well as the category structure and hierarchy.
        /// </returns>
        Task<RequestResult<IList<AchievementCategory>>> GetCharacterAchievementsAsync();

        /// <summary>
        ///     Get a list of all of the achievements that characters can earn as well as the category structure and hierarchy.
        /// </summary>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     A list of all of the achievements that characters can earn as well as the category structure and hierarchy.
        /// </returns>
        Task<RequestResult<IList<AchievementCategory>>> GetCharacterAchievementsAsync(Region region, Locale locale);

        /// <summary>
        ///     Get a list of all supported character classes.
        /// </summary>
        /// <returns>
        ///     A list of all supported character classes.
        /// </returns>
        Task<RequestResult<IList<CharacterClassData>>> GetCharacterClassesAsync();

        /// <summary>
        /// Get a list of all supported character classes.
        /// </summary>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        /// A list of all supported character classes.
        /// </returns>
        Task<RequestResult<IList<CharacterClassData>>> GetCharacterClassesAsync(Region region, Locale locale);

        /// <summary>
        ///     Get a list of all supported character races.
        /// </summary>
        /// <returns>
        ///     A list of all supported character races.
        /// </returns>
        Task<RequestResult<IList<CharacterRace>>> GetCharacterRacesAsync();

        /// <summary>
        ///     Get a list of all supported character races.
        /// </summary>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     A list of all supported character races.
        /// </returns>
        Task<RequestResult<IList<CharacterRace>>> GetCharacterRacesAsync(Region region, Locale locale);

        /// <summary>
        ///     Get the characters for a user account.
        /// </summary>
        /// <param name="accessToken">An OAuth access token for the user.</param>
        /// <returns>
        ///     The characters for a user account.
        /// </returns>
        Task<RequestResult<IList<GuildCharacter>>> GetCharactersAsync(string accessToken);

        /// <summary>
        ///     Get the characters for a user account.
        /// </summary>
        /// <param name="accessToken">An OAuth access token for the user.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <returns>
        ///     The characters for a user account.
        /// </returns>
        Task<RequestResult<IList<GuildCharacter>>> GetCharactersAsync(string accessToken, Region region);

        /// <summary>
        ///     Get the specified guild.
        /// </summary>
        /// <param name="realm">The realm.</param>
        /// <param name="guildName">The guild name.</param>
        /// <param name="fields">The guild fields to include.</param>
        /// <returns>
        ///     The specified guild.
        /// </returns>
        Task<RequestResult<Guild>> GetGuildAsync(string realm, string guildName, GuildFields fields = GuildFields.None);

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
        Task<RequestResult<Guild>> GetGuildAsync(string realm, string guildName, Region region, Locale locale, GuildFields fields = GuildFields.None);

        /// <summary>
        ///     Get a list of all guild achievements.
        /// </summary>
        /// <returns>
        ///     A list of all guild achievements.
        /// </returns>
        Task<RequestResult<IList<AchievementCategory>>> GetGuildAchievementsAsync();

        /// <summary>
        ///     Get a list of all guild achievements.
        /// </summary>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     A list of all guild achievements.
        /// </returns>
        Task<RequestResult<IList<AchievementCategory>>> GetGuildAchievementsAsync(Region region, Locale locale);

        /// <summary>
        ///     Get a list of all guild rewards.
        /// </summary>
        /// <returns>
        ///     A list of all guild rewards.
        /// </returns>
        Task<RequestResult<IList<Reward>>> GetGuildRewardsAsync();

        /// <summary>
        ///     Get a list of all guild rewards.
        /// </summary>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     A list of all guild rewards.
        /// </returns>
        Task<RequestResult<IList<Reward>>> GetGuildRewardsAsync(Region region, Locale locale);

        /// <summary>
        ///     Get the specified item.
        /// </summary>
        /// <param name="itemId">The item ID.</param>
        /// <returns>
        ///     The specified item.
        /// </returns>
        Task<RequestResult<Item>> GetItemAsync(int itemId);

        /// <summary>
        ///     Get the specified item.
        /// </summary>
        /// <param name="itemId">The item ID.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     The specified item.
        /// </returns>
        Task<RequestResult<Item>> GetItemAsync(int itemId, Region region, Locale locale);

        /// <summary>
        ///     Get a list of all item classes.
        /// </summary>
        /// <returns>
        ///     A list of all item classes.
        /// </returns>
        Task<RequestResult<IList<ItemClass>>> GetItemClassesAsync();

        /// <summary>
        ///     Get a list of all item classes.
        /// </summary>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     A list of all item classes.
        /// </returns>
        Task<RequestResult<IList<ItemClass>>> GetItemClassesAsync(Region region, Locale locale);

        /// <summary>
        ///     Get the specified item set.
        /// </summary>
        /// <param name="itemSetId">The item set ID.</param>
        /// <returns>
        ///     The specified item set.
        /// </returns>
        Task<RequestResult<ItemSet>> GetItemSetAsync(int itemSetId);

        /// <summary>
        ///     Get the specified item set.
        /// </summary>
        /// <param name="itemSetId">The item set ID.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     The specified item set.
        /// </returns>
        Task<RequestResult<ItemSet>> GetItemSetAsync(int itemSetId, Region region, Locale locale);

        /// <summary>
        ///     Get a list of all supported mounts.
        /// </summary>
        /// <returns>
        ///     A list of all supported mounts.
        /// </returns>
        Task<RequestResult<IList<Mount>>> GetMountsAsync();

        /// <summary>
        ///     Get a list of all supported pets.
        /// </summary>
        /// <returns>
        ///     A list of all supported pets.
        /// </returns>
        Task<RequestResult<IList<Pet>>> GetPetsAsync();

        /// <summary>
        ///     Get a list of all supported pets.
        /// </summary>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     A list of all supported pets.
        /// </returns>
        Task<RequestResult<IList<Pet>>> GetPetsAsync(Region region, Locale locale);

        /// <summary>
        ///     Get the specified pet ability.
        /// </summary>
        /// <param name="abilityId">The pet ability ID.</param>
        /// <returns>
        ///     The specified pet ability.
        /// </returns>
        Task<RequestResult<PetAbility>> GetPetAbilityAsync(int abilityId);

        /// <summary>
        ///     Get the specified pet ability.
        /// </summary>
        /// <param name="abilityId">The pet ability ID.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     The specified pet ability.
        /// </returns>
        Task<RequestResult<PetAbility>> GetPetAbilityAsync(int abilityId, Region region, Locale locale);

        /// <summary>
        ///     Get the specified pet species.
        /// </summary>
        /// <param name="speciesId">The pet species ID.</param>
        /// <returns>
        ///     The specified pet species.
        /// </returns>
        Task<RequestResult<PetSpecies>> GetPetSpeciesAsync(int speciesId);

        /// <summary>
        ///     Get the specified pet species.
        /// </summary>
        /// <param name="speciesId">The pet species ID.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     The specified pet species.
        /// </returns>
        Task<RequestResult<PetSpecies>> GetPetSpeciesAsync(int speciesId, Region region, Locale locale);

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
        Task<RequestResult<PetStats>> GetPetStatsAsync(int speciesId, int level, int breedId, BattlePetQuality quality);

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
        Task<RequestResult<PetStats>> GetPetStatsAsync(int speciesId, int level, int breedId, BattlePetQuality quality, Region region, Locale locale);

        /// <summary>
        ///     Get a list of all pet types.
        /// </summary>
        /// <returns>
        ///     A list of all pet types.
        /// </returns>
        Task<RequestResult<IList<PetType>>> GetPetTypesAsync();

        /// <summary>
        ///     Get a list of all pet types.
        /// </summary>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     A list of all pet types.
        /// </returns>
        Task<RequestResult<IList<PetType>>> GetPetTypesAsync(Region region, Locale locale);

        /// <summary>
        ///     Get the PvP leaderboard for the specified bracket.
        /// </summary>
        /// <param name="bracket">The PvP leaderboard bracket.  Valid entries are 2v2, 3v3, 5v5, and rbg.</param>
        /// <returns>
        ///     The PvP leaderboard for the specified bracket.
        /// </returns>
        Task<RequestResult<PvpLeaderboard>> GetPvpLeaderboardAsync(string bracket);

        /// <summary>
        ///     Get the PvP leaderboard for the specified bracket.
        /// </summary>
        /// <param name="bracket">The PvP leaderboard bracket.  Valid entries are 2v2, 3v3, 5v5, and rbg.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     The PvP leaderboard for the specified bracket.
        /// </returns>
        Task<RequestResult<PvpLeaderboard>> GetPvpLeaderboardAsync(string bracket, Region region, Locale locale);

        /// <summary>
        ///     Get the specified quest.
        /// </summary>
        /// <param name="questId">The quest ID.</param>
        /// <returns>
        ///     The specified quest.
        /// </returns>
        Task<RequestResult<Quest>> GetQuestAsync(int questId);

        /// <summary>
        ///     Get the specified quest.
        /// </summary>
        /// <param name="questId">The quest ID.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     The specified quest.
        /// </returns>
        Task<RequestResult<Quest>> GetQuestAsync(int questId, Region region, Locale locale);

        /// <summary>
        ///     Get the statuses for all realms.
        /// </summary>
        /// <returns>
        ///     The statuses for all realms.
        /// </returns>
        Task<RequestResult<IList<Realm>>> GetRealmStatusAsync();

        /// <summary>
        ///     Get the statuses for all realms.
        /// </summary>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     The statuses for all realms.
        /// </returns>
        Task<RequestResult<IList<Realm>>> GetRealmStatusAsync(Region region, Locale locale);

        /// <summary>
        ///     Get the specified recipe.
        /// </summary>
        /// <param name="recipeId">The recipe ID.</param>
        /// <returns>
        ///     The specified recipe.
        /// </returns>
        Task<RequestResult<Recipe>> GetRecipeAsync(int recipeId);

        /// <summary>
        ///     Get the specified recipe.
        /// </summary>
        /// <param name="recipeId">The recipe ID.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     The specified recipe.
        /// </returns>
        Task<RequestResult<Recipe>> GetRecipeAsync(int recipeId, Region region, Locale locale);

        /// <summary>
        ///     Get the specified spell.
        /// </summary>
        /// <param name="spellId">The spell ID.</param>
        /// <returns>
        ///     The specified spell.
        /// </returns>
        Task<RequestResult<Spell>> GetSpellAsync(int spellId);

        /// <summary>
        ///     Get the specified spell.
        /// </summary>
        /// <param name="spellId">The spell ID.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     The specified spell.
        /// </returns>
        Task<RequestResult<Spell>> GetSpellAsync(int spellId, Region region, Locale locale);

        /// <summary>
        ///     Get a dictionary of talents, indexed by character class.
        /// </summary>
        /// <returns>
        ///     A dictionary of talents, indexed by character class.
        /// </returns>
        Task<RequestResult<IDictionary<CharacterClass, TalentSet>>> GetTalentsAsync();

        /// <summary>
        ///     Get a dictionary of talents, indexed by character class.
        /// </summary>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     A dictionary of talents, indexed by character class.
        /// </returns>
        Task<RequestResult<IDictionary<CharacterClass, TalentSet>>> GetTalentsAsync(Region region, Locale locale);

        /// <summary>
        ///     Get user account details.
        /// </summary>
        /// <param name="accessToken">An OAuth access token for the user.</param>
        /// <returns>
        ///     User account details.
        /// </returns>
        Task<RequestResult<UserAccount>> GetUserAsync(string accessToken);

        /// <summary>
        ///     Get user account details.
        /// </summary>
        /// <param name="accessToken">An OAuth access token for the user.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <returns>
        ///     User account details.
        /// </returns>
        Task<RequestResult<UserAccount>> GetUserAsync(string accessToken, Region region);

        /// <summary>
        ///     Get the specified zone.
        /// </summary>
        /// <param name="zoneId">The zone ID.</param>
        /// <returns>
        ///     The specified zone.
        /// </returns>
        Task<RequestResult<Zone>> GetZoneAsync(int zoneId);

        /// <summary>
        ///     Get the specified zone.
        /// </summary>
        /// <param name="zoneId">The zone ID.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     The specified zone.
        /// </returns>
        Task<RequestResult<Zone>> GetZoneAsync(int zoneId, Region region, Locale locale);

        /// <summary>
        ///     Get a list of all supported zones.
        /// </summary>
        /// <returns>
        ///     A list of all supported zones.
        /// </returns>
        Task<RequestResult<IList<Zone>>> GetZonesAsync();

        /// <summary>
        ///     Get a list of all supported zones.
        /// </summary>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     A list of all supported zones.
        /// </returns>
        Task<RequestResult<IList<Zone>>> GetZonesAsync(Region region, Locale locale);
    }
}
