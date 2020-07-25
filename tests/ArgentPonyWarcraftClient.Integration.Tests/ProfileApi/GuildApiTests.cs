using Xunit;

namespace ArgentPonyWarcraftClient.Integration.Tests.ProfileApi
{
    public class GuildApiTests
    {
        [ResilientFact]
        public async void GetGuildAsync_Gets_Guild()
        {
            IGuildApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<Guild> result = await warcraftClient.GetGuildAsync("deathwing", "enigma", "profile-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetGuildActivityAsync_Gets_GuildActivity()
        {
            IGuildApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<GuildActivity> result = await warcraftClient.GetGuildActivityAsync("deathwing", "enigma", "profile-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetGuildAchievementsAsync_Gets_GuildAchievements()
        {
            IGuildApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<GuildAchievements> result = await warcraftClient.GetGuildAchievementsAsync("deathwing", "enigma", "profile-us");
            Assert.NotNull(result.Value);
        }

        [ResilientFact]
        public async void GetGuildRosterAsync_Gets_GuildRoster()
        {
            IGuildApi warcraftClient = ClientFactory.BuildClient();
            RequestResult<GuildRoster> result = await warcraftClient.GetGuildRosterAsync("deathwing", "enigma", "profile-us");
            Assert.NotNull(result.Value);
        }
    }
}
