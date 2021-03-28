using System;
using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A Mythic Keystone dungeon run.
    /// </summary>
    public record MythicKeystoneRun
    {
        /// <summary>
        /// Gets the timestamp when the run was completed.
        /// </summary>
        [JsonPropertyName("completed_timestamp")]
        public DateTimeOffset CompletedTimestamp { get; }

        /// <summary>
        /// Gets the duration.
        /// </summary>
        [JsonPropertyName("duration")]
        public TimeSpan Duration { get; }

        /// <summary>
        /// Gets the keystone level.
        /// </summary>
        [JsonPropertyName("keystone_level")]
        public int KeystoneLevel { get; }

        /// <summary>
        /// Gets references to the Mythic Keystone affixes for this run.
        /// </summary>
        [JsonPropertyName("keystone_affixes")]
        public MythicKeystoneAffixReference[] KeystoneAffixes { get; }

        /// <summary>
        /// Gets the party members for the Mythic Keystone run.
        /// </summary>
        [JsonPropertyName("members")]
        public MythicKeystonePartyMember[] Members { get; }

        /// <summary>
        /// A reference to the Mythic Keystone dungeon.
        /// </summary>
        [JsonPropertyName("dungeon")]
        public MythicKeystoneDungeonReference Dungeon { get; }

        /// <summary>
        /// Gets a value indicating whether the run was completed within the time limit.
        /// </summary>
        [JsonPropertyName("is_completed_within_time")]
        public bool IsCompletedWithinTime { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MythicKeystoneRun"/> class.
        /// </summary>
        /// <param name="completedTimestamp">The timestamp when the run was completed.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="keystoneLevel">The keystone level.</param>
        /// <param name="keystoneAffixes">References to the Mythic Keystone affixes for this run.</param>
        /// <param name="members">The party members for the Mythic Keystone run.</param>
        /// <param name="dungeon">The party members for the Mythic Keystone run.</param>
        /// <param name="isCompletedWithinTime">A value indicating whether the run was completed within the time limit.</param>
        [JsonConstructor]
        public MythicKeystoneRun(DateTimeOffset completedTimestamp, TimeSpan duration, int keystoneLevel, MythicKeystoneAffixReference[] keystoneAffixes, MythicKeystonePartyMember[] members, MythicKeystoneDungeonReference dungeon, bool isCompletedWithinTime)
        {
            CompletedTimestamp = completedTimestamp;
            Duration = duration;
            KeystoneLevel = keystoneLevel;
            KeystoneAffixes = keystoneAffixes;
            Members = members;
            Dungeon = dungeon;
            IsCompletedWithinTime = isCompletedWithinTime;
        }
    }
}
