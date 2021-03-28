using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of Mythic Keystone Leaderboard dungeon instances for a connected realm.
    /// </summary>
    public record MythicKeystoneLeaderboardsIndex
    {
        /// <summary>
        /// Gets links for the index of Mythic Keystone Leaderboards.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to the Mythic Keystone Leaderboards.
        /// </summary>
        [JsonPropertyName("current_leaderboards")]
        public MythicKeystoneLeaderboardReference[] CurrentLeaderboards { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MythicKeystoneLeaderboardsIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of Mythic Keystone Leaderboards.</param>
        /// <param name="currentLeaderboards">References to the Mythic Keystone Leaderboards.</param>
        [JsonConstructor]
        public MythicKeystoneLeaderboardsIndex(Links links, MythicKeystoneLeaderboardReference[] currentLeaderboards)
        {
            Links = links;
            CurrentLeaderboards = currentLeaderboards;
        }
    }
}
