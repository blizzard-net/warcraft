using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests
{
    public class WarcraftClientTests
    {
        private readonly string _apiKey;

        public WarcraftClientTests()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true)
                .AddEnvironmentVariables()
                .Build();

            _apiKey = configuration["blizzardApiKey"];
        }

        [Fact]
        public async void GetAchievementAsync_Gets_Achievement()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            RequestResult<Achievement> result = await warcraftClient.GetAchievementAsync(2144);
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetAuctionAsync_Gets_Auction()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            RequestResult<AuctionFiles> result = await warcraftClient.GetAuctionAsync("Norgannon");
            Assert.NotNull(result.Value.Files);

            RequestResult<AuctionHouseSnapshot> resultSnapshot = await warcraftClient.GetAuctionHouseSnapshotAsync(result.Value.Files.First().Url);
            Assert.NotNull(resultSnapshot.Value);
        }

        [Fact]
        public async void GetBattlegroupAsync_Gets_Battlegroups()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            RequestResult<IList<Battlegroup>> result = await warcraftClient.GetBattlegroupsAsync();
            Assert.NotNull(result.Value);
            Assert.NotEmpty(result.Value);
        }

        [Fact]
        public async void GetBossAsync_Gets_Boss()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            RequestResult<Boss> result = await warcraftClient.GetBossAsync(24723);
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetBossesAsync_Gets_Bosses()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            RequestResult<IList<Boss>> result = await warcraftClient.GetBossesAsync();
            Assert.NotNull(result.Value);
            Assert.NotEmpty(result.Value);
        }

        [Fact]
        public async void GetChallengesAsync_Gets_Challenges_For_Region()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            RequestResult<IList<Challenge>> result = await warcraftClient.GetChallengesAsync();
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetChallengesAsync_Gets_Challenges()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            RequestResult<IList<Challenge>> result = await warcraftClient.GetChallengesAsync("Norgannon");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetCharacterAsync_Gets_Character()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            RequestResult<Character> result = await warcraftClient.GetCharacterAsync("Norgannon", "Drinian", CharacterFields.All);
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetCharacterClassesAsync_Gets_Character_Classes()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            RequestResult<IList<CharacterClassData>> result = await warcraftClient.GetCharacterClassesAsync();
            Assert.NotNull(result.Value);
            Assert.NotEmpty(result.Value);
        }

        [Fact]
        public async void GetCharacterAchievementsAsync_Gets_Achievements()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            RequestResult<IList<AchievementCategory>> result = await warcraftClient.GetCharacterAchievementsAsync();
            Assert.NotNull(result.Value);
            Assert.NotEmpty(result.Value);
        }

        [Fact]
        public async void GetCharacterRacesAsync_Gets_Character_Races()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            RequestResult<IList<CharacterRace>> result = await warcraftClient.GetCharacterRacesAsync();
            Assert.NotNull(result.Value);
            Assert.NotEmpty(result.Value);
        }

        [Fact]
        public async void GetGuildAsync_Gets_Guild()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            RequestResult<Guild> result = await warcraftClient.GetGuildAsync("Norgannon", "Mythical Warriors", GuildFields.Challenge);
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetGuildAchievementsAsync_Gets_Guild_Achievements()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            RequestResult<IList<AchievementCategory>> result = await warcraftClient.GetGuildAchievementsAsync();
            Assert.NotNull(result.Value);
            Assert.NotEmpty(result.Value);
        }

        [Fact]
        public async void GetGuildPerksAsync_Gets_Guild_Perks()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            RequestResult<IList<Perk>> result = await warcraftClient.GetGuildPerksAsync();
            Assert.NotNull(result.Value);
            Assert.NotEmpty(result.Value);
        }

        [Fact]
        public async void GetGuildRewardsAsync_Gets_Guild_Rewards()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            RequestResult<IList<Reward>> result = await warcraftClient.GetGuildRewardsAsync();
            Assert.NotNull(result.Value);
            Assert.NotEmpty(result.Value);
        }

        [Fact]
        public async void GetItemAsync_Gets_Item()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            RequestResult<Item> result = await warcraftClient.GetItemAsync(18803);
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetItemClassesAsync_Gets_Item_Classes()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            RequestResult<IList<ItemClass>> result = await warcraftClient.GetItemClassesAsync();
            Assert.NotNull(result.Value);
            Assert.NotEmpty(result.Value);
        }

        [Fact]
        public async void GetItemSetAsync_Gets_Item_Set()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            RequestResult<ItemSet> result = await warcraftClient.GetItemSetAsync(1060);
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetMountsAsync_Gets_Mounts()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            RequestResult<IList<Mount>> result = await warcraftClient.GetMountsAsync();
            Assert.NotNull(result.Value);
            Assert.NotEmpty(result.Value);
        }

        [Fact]
        public async void GetPetsAsync_Gets_Pets()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            RequestResult<IList<Pet>> result = await warcraftClient.GetPetsAsync();
            Assert.NotNull(result.Value);
            Assert.NotEmpty(result.Value);
        }

        [Fact]
        public async void GetPetAbilityAsync_Gets_Pet_Ability()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            RequestResult<PetAbility> result = await warcraftClient.GetPetAbilityAsync(640);
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetPetSpeciesAsync_Gets_Pet_Species()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            RequestResult<PetSpecies> result = await warcraftClient.GetPetSpeciesAsync(258);
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetPetStatsAsync_Gets_Pet_Stats()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            RequestResult<PetStats> result = await warcraftClient.GetPetStatsAsync(258, 25, 5, BattlePetQuality.Epic);
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetPetTypesAsync_Gets_Pet_Types()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            RequestResult<IList<PetType>> result = await warcraftClient.GetPetTypesAsync();
            Assert.NotNull(result.Value);
            Assert.NotEmpty(result.Value);
        }

        [Fact]
        public async void GetPvpLeaderboardAsync_Gets_Leaderboard()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            RequestResult<PvpLeaderboard> result = await warcraftClient.GetPvpLeaderboardAsync("2v2");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetQuestAsync_Gets_Quest()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            RequestResult<Quest> result = await warcraftClient.GetQuestAsync(13146);
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetRealmsAsync_Gets_Realms()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            RequestResult<IList<Realm>> result = await warcraftClient.GetRealmStatusAsync();
            Assert.NotNull(result.Value);
            Assert.NotEmpty(result.Value);
        }

        [Fact]
        public async void GetRecipe_Gets_Recipe()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            RequestResult<Recipe> result = await warcraftClient.GetRecipeAsync(33994);
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetSpellAsync_Gets_Spell()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            RequestResult<Spell> result = await warcraftClient.GetSpellAsync(79733);
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetTalentsAsync_Gets_Talents()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            RequestResult<IDictionary<CharacterClass, TalentSet>> result = await warcraftClient.GetTalentsAsync();
            Assert.NotNull(result.Value);
            Assert.NotEmpty(result.Value);
        }

        [Fact]
        public async void GetZoneAsync_Gets_Zone()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            RequestResult<Zone> result = await warcraftClient.GetZoneAsync(4131);
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetZonesAsync_Gets_Zones()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            RequestResult<IList<Zone>> result = await warcraftClient.GetZonesAsync();
            Assert.NotEmpty(result.Value);
        }

        [Fact]
        public async void ProducesNotFoundError()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            RequestResult<Zone> result = await warcraftClient.GetZoneAsync(99999991);
            Assert.NotNull(result.Error);
            Assert.Equal("404", result.Error.Code);
            Assert.False(result.Success);
            Assert.Null(result.Value);
        }

        [Fact]
        public async void ProducesForbiddenError()
        {
            var warcraftClient = new WarcraftClient("345knkl23n4lkn23623la");
            RequestResult<Zone> result = await warcraftClient.GetZoneAsync(4131);
            Assert.NotNull(result.Error);
            Assert.Equal("403", result.Error.Code);
            Assert.False(result.Success);
            Assert.Null(result.Value);
        }
    }
}
