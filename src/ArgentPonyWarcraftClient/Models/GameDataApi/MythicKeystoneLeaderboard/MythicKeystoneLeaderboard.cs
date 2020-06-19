using System;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A Mythic Keystone Leaderboard for a period.
    /// </summary>
    public class MythicKeystoneLeaderboard
    {
        /// <summary>
        /// Gets links for the Mythic Keystone Leaderboard.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the map of the instance.
        /// </summary>
        [JsonProperty("map")]
        public Map Map { get; set; }

        /// <summary>
        /// Gets the unique identifier for the leaderboard period.
        /// </summary>
        [JsonProperty("period")]
        public long Period { get; set; }

        /// <summary>
        /// Gets the start timestamp for the time period.
        /// </summary>
        [JsonProperty("period_start_timestamp")]
        public DateTime PeriodStartTimestamp { get; set; }

        /// <summary>
        /// Gets the end timestamp for the time period.
        /// </summary>
        [JsonProperty("period_end_timestamp")]
        public DateTime PeriodEndTimestamp { get; set; }

        /// <summary>
        /// Gets a reference to the connected realm.
        /// </summary>
        [JsonProperty("connected_realm")]
        public Self ConnectedRealm { get; set; }

        /// <summary>
        /// Gets the leading troups in this connected realm for this instance and time period.
        /// </summary>
        [JsonProperty("leading_groups")]
        public LeadingGroup[] LeadingGroups { get; set; }

        /// <summary>
        /// Gets the mythic keystone affixes and starting levels.
        /// </summary>
        [JsonProperty("keystone_affixes")]
        public LeaderboardKeystoneAffix[] KeystoneAffixes { get; set; }

        /// <summary>
        /// Gets the map challenge mode ID.
        /// </summary>
        [JsonProperty("map_challenge_mode_id")]
        public long MapChallengeModeId { get; set; }

        /// <summary>
        /// Gets the name of the instance.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
