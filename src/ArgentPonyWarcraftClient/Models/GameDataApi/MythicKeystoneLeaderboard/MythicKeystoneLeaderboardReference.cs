using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a Mythic Keystone Leaderboard dungeon instance for a connected realm.
    /// </summary>
    public class MythicKeystoneLeaderboardReference
    {
        /// <summary>
        /// Gets the key for the Mythic Keystone Leaderboard.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the Mythic Keystone Leaderboard.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the Mythic Keystone Leaderboard.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
