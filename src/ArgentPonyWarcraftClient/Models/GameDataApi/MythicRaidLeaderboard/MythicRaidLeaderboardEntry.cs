using System;
using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An entry in a Mythic Raid leaderboard.
    /// </summary>
    public record MythicRaidLeaderboardEntry
    {
        /// <summary>
        /// Gets a reference to the guild.
        /// </summary>
        [JsonPropertyName("guild")]
        public GuildReferenceWithoutKeyAndFaction Guild { get; }

        /// <summary>
        /// Gets the faction.
        /// </summary>
        [JsonPropertyName("faction")]
        public EnumTypeWithoutName Faction { get; }

        /// <summary>
        /// Gets the timestamp.
        /// </summary>
        [JsonPropertyName("timestamp")]
        public DateTimeOffset Timestamp { get; }

        /// <summary>
        /// Gets the region.
        /// </summary>
        [JsonPropertyName("region")]
        public string Region { get; }

        /// <summary>
        /// Gets the rank.
        /// </summary>
        [JsonPropertyName("rank")]
        public int Rank { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MythicRaidLeaderboardEntry"/> class.
        /// </summary>
        /// <param name="guild">A reference to the guild.</param>
        /// <param name="faction">The faction.</param>
        /// <param name="timestamp">The timestamp.</param>
        /// <param name="region">The region.</param>
        /// <param name="rank">The rank.</param>
        [JsonConstructor]
        public MythicRaidLeaderboardEntry(GuildReferenceWithoutKeyAndFaction guild, EnumTypeWithoutName faction, DateTimeOffset timestamp, string region, int rank)
        {
            Guild = guild;
            Faction = faction;
            Timestamp = timestamp;
            Region = region;
            Rank = rank;
        }
    }
}
