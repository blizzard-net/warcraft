﻿using System;
using System.Text.Json.Serialization;

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
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the map of the instance.
        /// </summary>
        [JsonPropertyName("map")]
        public Map Map { get; set; }

        /// <summary>
        /// Gets the unique identifier for the leaderboard period.
        /// </summary>
        [JsonPropertyName("period")]
        public int Period { get; set; }

        /// <summary>
        /// Gets the start timestamp for the time period.
        /// </summary>
        [JsonPropertyName("period_start_timestamp")]
        public DateTimeOffset PeriodStartTimestamp { get; set; }

        /// <summary>
        /// Gets the end timestamp for the time period.
        /// </summary>
        [JsonPropertyName("period_end_timestamp")]
        public DateTimeOffset PeriodEndTimestamp { get; set; }

        /// <summary>
        /// Gets a reference to the connected realm.
        /// </summary>
        [JsonPropertyName("connected_realm")]
        public Self ConnectedRealm { get; set; }

        /// <summary>
        /// Gets the leading troups in this connected realm for this instance and time period.
        /// </summary>
        [JsonPropertyName("leading_groups")]
        public LeadingGroup[] LeadingGroups { get; set; }

        /// <summary>
        /// Gets the mythic keystone affixes and starting levels.
        /// </summary>
        [JsonPropertyName("keystone_affixes")]
        public LeaderboardKeystoneAffix[] KeystoneAffixes { get; set; }

        /// <summary>
        /// Gets the map challenge mode ID.
        /// </summary>
        [JsonPropertyName("map_challenge_mode_id")]
        public int MapChallengeModeId { get; set; }

        /// <summary>
        /// Gets the name of the instance.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
