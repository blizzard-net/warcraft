using System;
using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A mythic keystone period.
    /// </summary>
    public record MythicKeystonePeriod
    {
        /// <summary>
        /// Gets links for the mythic keystone period.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the mythic keystone period.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the start timestampe of the mythic keystone period.
        /// </summary>
        [JsonPropertyName("start_timestamp")]
        public DateTimeOffset StartTimestamp { get; }

        /// <summary>
        /// Gets the end timestampe of the mythic keystone period.
        /// </summary>
        [JsonPropertyName("end_timestamp")]
        public DateTimeOffset EndTimestamp { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MythicKeystonePeriod"/> class.
        /// </summary>
        /// <param name="links">Links for the mythic keystone period.</param>
        /// <param name="id">The ID of the mythic keystone period.</param>
        /// <param name="startTimestamp">The start timestampe of the mythic keystone period.</param>
        /// <param name="endTimestamp">The end timestampe of the mythic keystone period.</param>
        [JsonConstructor]
        public MythicKeystonePeriod(Links links, int id, DateTimeOffset startTimestamp, DateTimeOffset endTimestamp)
        {
            Links = links;
            Id = id;
            StartTimestamp = startTimestamp;
            EndTimestamp = endTimestamp;
        }
    }
}
