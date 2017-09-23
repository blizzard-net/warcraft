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
            IConfigurationRoot appSettings = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            _apiKey = appSettings["blizzardApiKey"];
        }

        [Fact]
        public async void GetAchievementAsync_Gets_Achievement()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            Achievement achievement = await warcraftClient.GetAchievementAsync(2144);
            Assert.NotNull(achievement);
        }

        [Fact]
        public async void GetAuctionAsync_Gets_Auction()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            AuctionFiles auctionFiles = await warcraftClient.GetAuctionAsync("Norgannon");
            Assert.NotNull(auctionFiles);

            AuctionHouseSnapshot snapshot = await warcraftClient.GetAuctionHouseSnapshotAsync(auctionFiles.Files.First().Url);
            Assert.NotNull(snapshot);
        }

        [Fact]
        public async void GetBattlegroupAsync_Gets_Battlegroups()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            IList<Battlegroup> battlegroups = await warcraftClient.GetBattlegroupsAsync();
            Assert.NotNull(battlegroups);
            Assert.NotEmpty(battlegroups);
        }

        [Fact]
        public async void GetBossAsync_Gets_Boss()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            Boss boss = await warcraftClient.GetBossAsync(24723);
            Assert.NotNull(boss);
        }

        [Fact]
        public async void GetBossesAsync_Gets_Bosses()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            List<Boss> bosses = await warcraftClient.GetBossesAsync();
            Assert.NotNull(bosses);
            Assert.NotEmpty(bosses);
        }

        [Fact]
        public async void GetChallengesAsync_Gets_Challenges_For_Region()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            IList<Challenge> challenges = await warcraftClient.GetChallengesAsync();
            Assert.NotNull(challenges);
        }

        [Fact]
        public async void GetChallengesAsync_Gets_Challenges()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            IList<Challenge> challenges = await warcraftClient.GetChallengesAsync("Norgannon");
            Assert.NotNull(challenges);
        }

        [Fact]
        public async void GetCharacterAsync_Gets_Character()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            Character character = await warcraftClient.GetCharacterAsync("Norgannon", "Drinian", CharacterFields.All);
            Assert.NotNull(character);
        }

        [Fact]
        public async void GetCharacterClassesAsync_Gets_Character_Classes()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            IList<CharacterClassData> chararcterClasses = await warcraftClient.GetCharacterClassesAsync();
            Assert.NotNull(chararcterClasses);
            Assert.NotEmpty(chararcterClasses);
        }

        [Fact]
        public async void GetCharacterAchievementsAsync_Gets_Achievements()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            IList<AchievementCategory> achievementCategories = await warcraftClient.GetCharacterAchievementsAsync();
            Assert.NotNull(achievementCategories);
            Assert.NotEmpty(achievementCategories);
        }

        [Fact]
        public async void GetCharacterRacesAsync_Gets_Character_Races()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            IList<CharacterRace> characterRaces = await warcraftClient.GetCharacterRacesAsync();
            Assert.NotNull(characterRaces);
            Assert.NotEmpty(characterRaces);
        }

        [Fact]
        public async void GetGuildAsync_Gets_Guild()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            Guild guild = await warcraftClient.GetGuildAsync("Norgannon", "Mythical Warriors", GuildFields.Challenge);
            Assert.NotNull(guild);
        }

        [Fact]
        public async void GetGuildAchievementsAsync_Gets_Guild_Achievements()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            IList<AchievementCategory> achievements = await warcraftClient.GetGuildAchievementsAsync();
            Assert.NotNull(achievements);
            Assert.NotEmpty(achievements);
        }

        [Fact]
        public async void GetGuildPerksAsync_Gets_Guild_Perks()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            IList<Perk> perks = await warcraftClient.GetGuildPerksAsync();
            Assert.NotNull(perks);
            Assert.NotEmpty(perks);
        }

        [Fact]
        public async void GetGuildRewardsAsync_Gets_Guild_Rewards()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            IList<Reward> rewards = await warcraftClient.GetGuildRewardsAsync();
            Assert.NotNull(rewards);
            Assert.NotEmpty(rewards);
        }

        [Fact]
        public async void GetItemAsync_Gets_Item()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            Item item = await warcraftClient.GetItemAsync(18803);
            Assert.NotNull(item);
        }

        [Fact]
        public async void GetItemClassesAsync_Gets_Item_Classes()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            IList<ItemClass> itemClasses = await warcraftClient.GetItemClassesAsync();
            Assert.NotNull(itemClasses);
            Assert.NotEmpty(itemClasses);
        }

        [Fact]
        public async void GetItemSetAsync_Gets_Item_Set()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            ItemSet itemSet = await warcraftClient.GetItemSetAsync(1060);
            Assert.NotNull(itemSet);
        }

        [Fact]
        public async void GetMountsAsync_Gets_Mounts()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            IList<Mount> mounts = await warcraftClient.GetMountsAsync();
            Assert.NotNull(mounts);
            Assert.NotEmpty(mounts);
        }

        [Fact]
        public async void GetPetsAsync_Gets_Pets()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            IList<Pet> pets = await warcraftClient.GetPetsAsync();
            Assert.NotNull(pets);
            Assert.NotEmpty(pets);
        }

        [Fact]
        public async void GetPetAbilityAsync_Gets_Pet_Ability()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            PetAbility ability = await warcraftClient.GetPetAbilityAsync(640);
            Assert.NotNull(ability);
        }

        [Fact]
        public async void GetPetSpeciesAsync_Gets_Pet_Species()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            PetSpecies species = await warcraftClient.GetPetSpeciesAsync(258);
            Assert.NotNull(species);
        }

        [Fact]
        public async void GetPetStatsAsync_Gets_Pet_Stats()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            PetStats stats = await warcraftClient.GetPetStatsAsync(258, 25, 5, BattlePetQuality.Epic);
            Assert.NotNull(stats);
        }

        [Fact]
        public async void GetPetTypesAsync_Gets_Pet_Types()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            IList<PetType> petTypes = await warcraftClient.GetPetTypesAsync();
            Assert.NotNull(petTypes);
            Assert.NotEmpty(petTypes);
        }

        [Fact]
        public async void GetPvpLeaderboardAsync_Gets_Leaderboard()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            PvpLeaderboard leaderboard = await warcraftClient.GetPvpLeaderboardAsync("2v2");
            Assert.NotNull(leaderboard);
        }

        [Fact]
        public async void GetQuestAsync_Gets_Quest()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            Quest quest = await warcraftClient.GetQuestAsync(13146);
            Assert.NotNull(quest);
        }

        [Fact]
        public async void GetRealmsAsync_Gets_Realms()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            IList<Realm> realms = await warcraftClient.GetRealmStatusAsync();
            Assert.NotNull(realms);
            Assert.NotEmpty(realms);
        }

        [Fact]
        public async void GetRecipe_Gets_Recipe()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            Recipe recipe = await warcraftClient.GetRecipeAsync(33994);
            Assert.NotNull(recipe);
        }

        [Fact]
        public async void GetSpellAsync_Gets_Spell()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            Spell spell = await warcraftClient.GetSpellAsync(8056);
            Assert.NotNull(spell);
        }

        [Fact]
        public async void GetTalentsAsync_Gets_Talents()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            IDictionary<CharacterClass, TalentSet> talents = await warcraftClient.GetTalentsAsync();
            Assert.NotNull(talents);
            Assert.NotEmpty(talents);
        }

        [Fact]
        public async void GetZoneAsync_Gets_Zone()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            Zone zone = await warcraftClient.GetZoneAsync(4131);
            Assert.NotNull(zone);
        }

        [Fact]
        public async void GetZonesAsync_Gets_Zones()
        {
            var warcraftClient = new WarcraftClient(_apiKey);
            IList<Zone> zones = await warcraftClient.GetZonesAsync();
            Assert.NotNull(zones);
            Assert.NotEmpty(zones);
        }
    }
}
