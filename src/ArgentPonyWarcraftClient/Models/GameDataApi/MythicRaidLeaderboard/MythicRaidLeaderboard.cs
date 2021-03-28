using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// The Mythic Raid leaderboard for a given raid and faction.
    /// </summary>
    public record MythicRaidLeaderboard
    {
        /// <summary>
        /// Gets links for the Mythic Raid leaderboard.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the slug for the raid and faction.
        /// </summary>
        [JsonPropertyName("slug")]
        public string Slug { get; }

        /// <summary>
        /// Gets the criteria type.
        /// </summary>
        [JsonPropertyName("criteria_type")]
        public string CriteriaType { get; }

        /// <summary>
        /// Gets a reference to the zone for the raid.
        /// </summary>
        [JsonPropertyName("zone")]
        public ZoneReference Zone { get; }

        /// <summary>
        /// Gets the entries for the Mythic Raid leaderboard.
        /// </summary>
        [JsonPropertyName("entries")]
        public MythicRaidLeaderboardEntry[] Entries { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MythicRaidLeaderboard"/> class.
        /// </summary>
        /// <param name="links">Links for the Mythic Raid leaderboard.</param>
        /// <param name="slug">The slug for the raid and faction.</param>
        /// <param name="criteriaType">The criteria type.</param>
        /// <param name="zone">A reference to the zone for the raid.</param>
        /// <param name="entries">The entries for the Mythic Raid leaderboard.</param>
        [JsonConstructor]
        public MythicRaidLeaderboard(Links links, string slug, string criteriaType, ZoneReference zone, MythicRaidLeaderboardEntry[] entries)
        {
            Links = links;
            Slug = slug;
            CriteriaType = criteriaType;
            Zone = zone;
            Entries = entries;
        }
    }
}
