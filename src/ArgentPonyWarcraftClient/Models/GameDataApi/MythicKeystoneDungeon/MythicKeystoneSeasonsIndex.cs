using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of mythic keystone seasons.
    /// </summary>
    public record MythicKeystoneSeasonsIndex
    {
        /// <summary>
        /// Gets links for the index of mythic keystone seasons.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to the mythic keystone seasons.
        /// </summary>
        [JsonPropertyName("seasons")]
        public MythicKeystoneSeasonReference[] Seasons { get; }

        /// <summary>
        /// Gets a reference to the current mythic keystone season.
        /// </summary>
        [JsonPropertyName("current_season")]
        public MythicKeystoneSeasonReference CurrentSeason { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MythicKeystoneSeasonsIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of mythic keystone seasons.</param>
        /// <param name="seasons">References to the mythic keystone seasons.</param>
        /// <param name="currentSeason">A reference to the current mythic keystone season.</param>
        [JsonConstructor]
        public MythicKeystoneSeasonsIndex(Links links, MythicKeystoneSeasonReference[] seasons, MythicKeystoneSeasonReference currentSeason)
        {
            Links = links;
            Seasons = seasons;
            CurrentSeason = currentSeason;
        }
    }
}
