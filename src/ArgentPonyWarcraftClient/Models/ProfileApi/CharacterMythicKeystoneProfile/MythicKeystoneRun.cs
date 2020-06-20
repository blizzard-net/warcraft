using System;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A Mythic Keystone dungeon run.
    /// </summary>
    public class MythicKeystoneRun
    {
        /// <summary>
        /// Gets the timestamp when the run was completed.
        /// </summary>
        [JsonProperty("completed_timestamp")]
        public DateTime CompletedTimestamp { get; set; }

        /// <summary>
        /// Gets the duration.
        /// </summary>
        [JsonProperty("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// Gets the keystone level.
        /// </summary>
        [JsonProperty("keystone_level")]
        public long KeystoneLevel { get; set; }

        /// <summary>
        /// Gets references to the Mythic Keystone affixes for this run.
        /// </summary>
        [JsonProperty("keystone_affixes")]
        public MythicKeystoneAffixReference[] KeystoneAffixes { get; set; }

        /// <summary>
        /// Gets the party members for the Mythic Keystone run.
        /// </summary>
        [JsonProperty("members")]
        public MythicKeystonePartyMember[] Members { get; set; }

        /// <summary>
        /// A reference to the Mythic Keystone dungeon.
        /// </summary>
        [JsonProperty("dungeon")]
        public MythicKeystoneDungeonReference Dungeon { get; set; }

        /// <summary>
        /// Gets a value indicating whether the run was completed within the time limit.
        /// </summary>
        [JsonProperty("is_completed_within_time")]
        public bool IsCompletedWithinTime { get; set; }
    }
}
