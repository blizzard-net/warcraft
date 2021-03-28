using System;
using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A mythic keystone season.
    /// </summary>
    public record MythicKeystoneSeason
    {
        /// <summary>
        /// Gets links for the mythic keystone season.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the mythic keystone season.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the start timestamp of the mythic keystone season.
        /// </summary>
        [JsonPropertyName("start_timestamp")]
        public DateTimeOffset StartTimestamp { get; }

        /// <summary>
        /// Gets the end timestamp of the mythic keystone season.
        /// </summary>
        [JsonPropertyName("end_timestamp")]
        public DateTimeOffset EndTimestamp { get; }

        /// <summary>
        /// Gets refernces to the periods in the mythic keystone season.
        /// </summary>
        [JsonPropertyName("periods")]
        public MythicKeystonePeriodReference[] Periods { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MythicKeystoneSeason"/> class.
        /// </summary>
        /// <param name="links">Links for the mythic keystone season.</param>
        /// <param name="id">The ID of the mythic keystone season.</param>
        /// <param name="startTimestamp">The start timestamp of the mythic keystone season.</param>
        /// <param name="endTimestamp">The end timestamp of the mythic keystone season.</param>
        /// <param name="periods">Refernces to the periods in the mythic keystone season.</param>
        [JsonConstructor]
        public MythicKeystoneSeason(Links links, int id, DateTimeOffset startTimestamp, DateTimeOffset endTimestamp, MythicKeystonePeriodReference[] periods)
        {
            Links = links;
            Id = id;
            StartTimestamp = startTimestamp;
            EndTimestamp = endTimestamp;
            Periods = periods;
        }
    }
}
