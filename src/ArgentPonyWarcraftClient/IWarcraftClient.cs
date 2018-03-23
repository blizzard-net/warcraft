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
        Task<RequestResult<Achievement>> GetAchievementAsync(int id, Region region, string locale);

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
        Task<RequestResult<AuctionFiles>> GetAuctionAsync(string realm, Region region, string locale);

        /// <summary>
        ///     Get the auction house snapshot from the specified file.
        /// </summary>
        /// <param name="url">The URL for the auction house file.</param>
        /// <returns>
        ///     The auction house snapshot from the specified file.
        /// </returns>
        Task<RequestResult<AuctionHouseSnapshot>> GetAuctionHouseSnapshotAsync(string url);

        /// <summary>
        ///     Get a list of all supported battlegroups.
        /// </summary>
        /// <returns>
        ///     A list of all supported battlegroups.
        /// </returns>
        Task<RequestResult<IList<Battlegroup>>> GetBattlegroupsAsync();

        /// <summary>
        ///     Get a list of all supported battlegroups.
        /// </summary>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     A list of all supported battlegroups.
        /// </returns>
        Task<RequestResult<IList<Battlegroup>>> GetBattlegroupsAsync(Region region, string locale);

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
        Task<RequestResult<Boss>> GetBossAsync(int id, Region region, string locale);

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
        Task<RequestResult<IList<Boss>>> GetBossesAsync(Region region, string locale);

        /// <summary>
        ///     Get the challenge mode data for the entire region.
        /// </summary>
        /// <returns>
        ///     The challenge mode data for the entire region.
        /// </returns>
        Task<RequestResult<IList<Challenge>>> GetChallengesAsync();

        /// <summary>
        ///     Get the challenge mode data for the entire region.
        /// </summary>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     The challenge mode data for the entire region.
        /// </returns>
        Task<RequestResult<IList<Challenge>>> GetChallengesAsync(Region region, string locale);

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
        Task<RequestResult<IList<Challenge>>> GetChallengesAsync(string realm, Region region, string locale);

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
        Task<RequestResult<Character>> GetCharacterAsync(string realm, string characterName, Region region, string locale, CharacterFields fields = CharacterFields.None);

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
        Task<RequestResult<IList<AchievementCategory>>> GetCharacterAchievementsAsync(Region region, string locale);

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
        Task<RequestResult<IList<CharacterClassData>>> GetCharacterClassesAsync(Region region, string locale);

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
        Task<RequestResult<IList<CharacterRace>>> GetCharacterRacesAsync(Region region, string locale);

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
        Task<RequestResult<Guild>> GetGuildAsync(string realm, string guildName, Region region, string locale, GuildFields fields = GuildFields.None);

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
        Task<RequestResult<IList<AchievementCategory>>> GetGuildAchievementsAsync(Region region, string locale);
    }
}
