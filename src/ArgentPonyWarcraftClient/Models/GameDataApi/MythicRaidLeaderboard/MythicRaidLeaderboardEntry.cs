using System;
using System.Text.Json.Serialization;

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
        [JsonPropertyName("guild")]
        public GuildReferenceWithoutKeyAndFaction Guild { get; set; }

        /// <summary>
        /// Gets the faction.
        /// </summary>
        [JsonPropertyName("faction")]
        public EnumTypeWithoutName Faction { get; set; }

        /// <summary>
        /// Gets the timestamp.
        /// </summary>
        [JsonPropertyName("timestamp")]
        public DateTimeOffset Timestamp { get; set; }

        /// <summary>
        /// Gets the region.
        /// </summary>
        [JsonPropertyName("region")]
        public string Region { get; set; }

        /// <summary>
        /// Gets the rank.
        /// </summary>
        [JsonPropertyName("rank")]
        public int Rank { get; set; }
    }
}
