using System;
using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A Mythic Keystone Leaderboard for a period.
    /// </summary>
    public record MythicKeystoneLeaderboard
    {
        /// <summary>
        /// Gets links for the Mythic Keystone Leaderboard.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the map of the instance.
        /// </summary>
        [JsonPropertyName("map")]
        public Map Map { get; }

        /// <summary>
        /// Gets the unique identifier for the leaderboard period.
        /// </summary>
        [JsonPropertyName("period")]
        public int Period { get; }

        /// <summary>
        /// Gets the start timestamp for the time period.
        /// </summary>
        [JsonPropertyName("period_start_timestamp")]
        public DateTimeOffset PeriodStartTimestamp { get; }

        /// <summary>
        /// Gets the end timestamp for the time period.
        /// </summary>
        [JsonPropertyName("period_end_timestamp")]
        public DateTimeOffset PeriodEndTimestamp { get; }

        /// <summary>
        /// Gets a reference to the connected realm.
        /// </summary>
        [JsonPropertyName("connected_realm")]
        public Self ConnectedRealm { get; }

        /// <summary>
        /// Gets the leading troups in this connected realm for this instance and time period.
        /// </summary>
        [JsonPropertyName("leading_groups")]
        public LeadingGroup[] LeadingGroups { get; }

        /// <summary>
        /// Gets the mythic keystone affixes and starting levels.
        /// </summary>
        [JsonPropertyName("keystone_affixes")]
        public LeaderboardKeystoneAffix[] KeystoneAffixes { get; }

        /// <summary>
        /// Gets the map challenge mode ID.
        /// </summary>
        [JsonPropertyName("map_challenge_mode_id")]
        public int MapChallengeModeId { get; }

        /// <summary>
        /// Gets the name of the instance.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MythicKeystoneLeaderboard"/> class.
        /// </summary>
        /// <param name="links">Links for the Mythic Keystone Leaderboard.</param>
        /// <param name="map">The map of the instance.</param>
        /// <param name="period">The unique identifier for the leaderboard period.</param>
        /// <param name="periodStartTimestamp">The start timestamp for the time period.</param>
        /// <param name="periodEndTimestamp">The end timestamp for the time period.</param>
        /// <param name="connectedRealm">A reference to the connected realm.</param>
        /// <param name="leadingGroups">The leading troups in this connected realm for this instance and time period.</param>
        /// <param name="keystoneAffixes">The mythic keystone affixes and starting levels.</param>
        /// <param name="mapChallengeModeId">The map challenge mode ID.</param>
        /// <param name="name">The name of the instance.</param>
        [JsonConstructor]
        public MythicKeystoneLeaderboard(Links links, Map map, int period, DateTimeOffset periodStartTimestamp, DateTimeOffset periodEndTimestamp, Self connectedRealm, LeadingGroup[] leadingGroups, LeaderboardKeystoneAffix[] keystoneAffixes, int mapChallengeModeId, string name)
        {
            Links = links;
            Map = map;
            Period = period;
            PeriodStartTimestamp = periodStartTimestamp;
            PeriodEndTimestamp = periodEndTimestamp;
            ConnectedRealm = connectedRealm;
            LeadingGroups = leadingGroups;
            KeystoneAffixes = keystoneAffixes;
            MapChallengeModeId = mapChallengeModeId;
            Name = name;
        }
    }
}
