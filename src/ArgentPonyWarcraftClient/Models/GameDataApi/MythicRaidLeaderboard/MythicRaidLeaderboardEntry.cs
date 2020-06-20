using System;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An entry in a Mythic Raid leaderboard.
    /// </summary>
    public class MythicRaidLeaderboardEntry
    {
        /// <summary>
        /// Gets a reference to the guild.
        /// </summary>
        [JsonProperty("guild")]
        public GuildReferenceWithoutKeyAndFaction Guild { get; set; }

        /// <summary>
        /// Gets the faction.
        /// </summary>
        [JsonProperty("faction")]
        public EnumTypeWithoutName Faction { get; set; }

        /// <summary>
        /// Gets the timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Gets the region.
        /// </summary>
        [JsonProperty("region")]
        public string Region { get; set; }

        /// <summary>
        /// Gets the rank.
        /// </summary>
        [JsonProperty("rank")]
        public long Rank { get; set; }
    }
}
