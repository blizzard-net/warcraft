using System;
using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A leading group.
    /// </summary>
    public record LeadingGroup
    {
        /// <summary>
        /// Gets the ranking of the group.
        /// </summary>
        [JsonPropertyName("ranking")]
        public int Ranking { get; }

        /// <summary>
        /// Gets the duration of the run.
        /// </summary>
        [JsonPropertyName("duration")]
        public TimeSpan Duration { get; }

        /// <summary>
        /// Gets the timestamp of the completion.
        /// </summary>
        [JsonPropertyName("completed_timestamp")]
        public DateTimeOffset CompletedTimestamp { get; }

        /// <summary>
        /// Gets the keystone level.
        /// </summary>
        [JsonPropertyName("keystone_level")]
        public int KeystoneLevel { get; }

        /// <summary>
        /// Gets the members of the group.
        /// </summary>
        [JsonPropertyName("members")]
        public Member[] Members { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LeadingGroup"/> class.
        /// </summary>
        /// <param name="ranking">The ranking of the group.</param>
        /// <param name="duration">The duration of the run.</param>
        /// <param name="completedTimestamp">The timestamp of the completion.</param>
        /// <param name="keystoneLevel">The keystone level.</param>
        /// <param name="members">The members of the group.</param>
        [JsonConstructor]
        public LeadingGroup(int ranking, TimeSpan duration, DateTimeOffset completedTimestamp, int keystoneLevel, Member[] members)
        {
            Ranking = ranking;
            Duration = duration;
            CompletedTimestamp = completedTimestamp;
            KeystoneLevel = keystoneLevel;
            Members = members;
        }
    }
}
