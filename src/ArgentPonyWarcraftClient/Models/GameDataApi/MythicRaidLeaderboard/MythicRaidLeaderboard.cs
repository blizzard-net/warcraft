using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// The Mythic Raid leaderboard for a given raid and faction.
    /// </summary>
    public class MythicRaidLeaderboard
    {
        /// <summary>
        /// Gets links for the Mythic Raid leaderboard.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the slug for the raid and faction.
        /// </summary>
        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Gets the criteria type.
        /// </summary>
        [JsonPropertyName("criteria_type")]
        public string CriteriaType { get; set; }

        /// <summary>
        /// Gets a reference to the zone for the raid.
        /// </summary>
        [JsonPropertyName("zone")]
        public ZoneReference Zone { get; set; }

        /// <summary>
        /// Gets the entries for the Mythic Raid leaderboard.
        /// </summary>
        [JsonPropertyName("entries")]
        public MythicRaidLeaderboardEntry[] Entries { get; set; }
    }
}
