using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of Mythic Keystone Leaderboard dungeon instances for a connected realm.
    /// </summary>
    public class MythicKeystoneLeaderboardsIndex
    {
        /// <summary>
        /// Gets links for the index of Mythic Keystone Leaderboards.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the Mythic Keystone Leaderboards.
        /// </summary>
        [JsonProperty("current_leaderboards")]
        public MythicKeystoneLeaderboardReference[] CurrentLeaderboards { get; set; }
    }
}
