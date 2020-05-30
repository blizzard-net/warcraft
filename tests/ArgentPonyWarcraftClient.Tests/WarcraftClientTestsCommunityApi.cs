using System.Collections.Generic;
using ArgentPonyWarcraftClient.Community;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests
{
    public class WarcraftClientTestsCommunityApi
    {
        [Fact]
        public async void GetAchievementAsync_Gets_Achievement()
        {
            IWarcraftClient warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/wow/achievement/2144?locale=en_US",
                responseContent: Resources.AchievementResponse);

            RequestResult<Achievement> result = await warcraftClient.GetAchievementAsync(2144);
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetChallengesAsync_Gets_Challenges()
        {
            IWarcraftClient warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/wow/challenge/Norgannon?locale=en_US",
                responseContent: Resources.ChallengesResponse);

            RequestResult<IList<Challenge>> result = await warcraftClient.GetChallengesAsync("Norgannon");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetCharacterAsync_Gets_Character()
        {
            IWarcraftClient warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/wow/character/Norgannon/Thorpe?&locale=en_US&fields=achievements,appearance,guild,hunter pets,items,mounts,pets,pet slots,professions,progression,pvp,quests,reputation,statistics,stats,talents,titles",
                responseContent: Resources.CharacterResponse);

            RequestResult<Character> result = await warcraftClient.GetCharacterAsync("Norgannon", "Thorpe", CharacterFields.All);
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetCharacterClassesAsync_Gets_Character_Classes()
        {
            IWarcraftClient warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/wow/data/character/classes?locale=en_US",
                responseContent: Resources.CharacterClassesResponse);

            RequestResult<IList<CharacterClassData>> result = await warcraftClient.GetCharacterClassesAsync();
            Assert.NotNull(result.Value);
            Assert.NotEmpty(result.Value);
        }

        [Fact]
        public async void GetCharacterAchievementsAsync_Gets_Achievements()
        {
            IWarcraftClient warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/wow/data/character/achievements?locale=en_US",
                responseContent: Resources.CharacterAchievementsResponse);

            RequestResult<IList<AchievementCategory>> result = await warcraftClient.GetCharacterAchievementsAsync();
            Assert.NotNull(result.Value);
            Assert.NotEmpty(result.Value);
        }

        [Fact]
        public async void GetCharacterRacesAsync_Gets_Character_Races()
        {
            IWarcraftClient warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/wow/data/character/races?locale=en_US",
                responseContent: Resources.CharacterRacesResponse);

            RequestResult<IList<CharacterRace>> result = await warcraftClient.GetCharacterRacesAsync();
            Assert.NotNull(result.Value);
            Assert.NotEmpty(result.Value);
        }

        [Fact]
        public async void GetCharactersAsync_Gets_Characters()
        {
            IWarcraftClient warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/wow/user/characters?access_token=tokenhere",
                responseContent: Resources.CharactersResponse);

            RequestResult<IList<GuildCharacter>> result = await warcraftClient.GetCharactersAsync("tokenhere");
            Assert.NotNull(result.Value);
            Assert.NotEmpty(result.Value);
        }

        [Fact]
        public async void GetGuildAsync_Gets_Guild()
        {
            IWarcraftClient warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/wow/guild/Norgannon/Mythical%20Warriors?locale=en_US",
                responseContent: Resources.GuildResponse);

            RequestResult<Guild> result = await warcraftClient.GetGuildAsync("Norgannon", "Mythical Warriors", GuildFields.None);
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetGuildAchievementsAsync_Gets_Guild_Achievements()
        {
            IWarcraftClient warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/wow/data/guild/achievements?locale=en_US",
                responseContent: Resources.GuildAchievementsResponse);

            RequestResult<IList<AchievementCategory>> result = await warcraftClient.GetGuildAchievementsAsync();
            Assert.NotNull(result.Value);
            Assert.NotEmpty(result.Value);
        }

        [Fact]
        public async void GetMountsAsync_Gets_Mounts()
        {
            IWarcraftClient warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/wow/mount/?locale=en_US",
                responseContent: Resources.MountsResponse);

            RequestResult<IList<Mount>> result = await warcraftClient.GetMountsAsync();
            Assert.NotNull(result.Value);
            Assert.NotEmpty(result.Value);
        }

        [Fact]
        public async void GetPetTypesAsync_Gets_Pet_Types()
        {
            IWarcraftClient warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/wow/data/pet/types?locale=en_US",
                responseContent: Resources.PetTypesResponse);

            RequestResult<IList<PetType>> result = await warcraftClient.GetPetTypesAsync();
            Assert.NotNull(result.Value);
            Assert.NotEmpty(result.Value);
        }

        [Fact]
        public async void GetPvpLeaderboardAsync_Gets_Leaderboard()
        {
            IWarcraftClient warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/wow/leaderboard/2v2?locale=en_US",
                responseContent: Resources.PvpLeaderboardResponse);

            RequestResult<PvpLeaderboard> result = await warcraftClient.GetPvpLeaderboardAsync("2v2");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetQuestAsync_Gets_Quest()
        {
            IWarcraftClient warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/wow/quest/13146?locale=en_US",
                responseContent: Resources.QuestResponse);

            RequestResult<Quest> result = await warcraftClient.GetQuestAsync(13146);
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetRealmsAsync_Gets_Realms()
        {
            IWarcraftClient warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/wow/realm/status?locale=en_US",
                responseContent: Resources.RealmsResponse);

            RequestResult<IList<Realm>> result = await warcraftClient.GetRealmStatusAsync();
            Assert.NotNull(result.Value);
            Assert.NotEmpty(result.Value);
        }

        [Fact]
        public async void GetRecipe_Gets_Recipe()
        {
            IWarcraftClient warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/wow/recipe/33994?locale=en_US",
                responseContent: Resources.RecipeResponse);

            RequestResult<Recipe> result = await warcraftClient.GetRecipeAsync(33994);
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetSpellAsync_Gets_Spell()
        {
            IWarcraftClient warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/wow/spell/79733?locale=en_US",
                responseContent: Resources.SpellResponse);

            RequestResult<Spell> result = await warcraftClient.GetSpellAsync(79733);
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetTalentsAsync_Gets_Talents()
        {
            IWarcraftClient warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/wow/data/talents?locale=en_US",
                responseContent: Resources.TalentsResponse);

            RequestResult<IDictionary<CharacterClass, TalentSet>> result = await warcraftClient.GetTalentsAsync();
            Assert.NotNull(result.Value);
            Assert.NotEmpty(result.Value);
        }

        [Fact]
        public async void GetUserAsync_Gets_User()
        {
            IWarcraftClient warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/account/user?access_token=tokenhere",
                responseContent: Resources.UserResponse);

            RequestResult<UserAccount> result = await warcraftClient.GetUserAsync("tokenhere");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetZoneAsync_Gets_Zone()
        {
            IWarcraftClient warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/wow/zone/4131?locale=en_US",
                responseContent: Resources.ZoneResponse);

            RequestResult<Zone> result = await warcraftClient.GetZoneAsync(4131);
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetZonesAsync_Gets_Zones()
        {
            IWarcraftClient warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/wow/zone/?locale=en_US",
                responseContent: Resources.ZonesResponse);

            RequestResult<IList<Zone>> result = await warcraftClient.GetZonesAsync();
            Assert.NotEmpty(result.Value);
        }

        
    }
}
