using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of playable races.
    /// </summary>
    public record PlayableRacesIndex
    {
        /// <summary>
        /// Gets links for the index of playable races.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to the playable races.
        /// </summary>
        [JsonPropertyName("races")]
        public PlayableRaceReference[] Races { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayableRacesIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of playable races.</param>
        /// <param name="races">References to the playable races.</param>
        [JsonConstructor]
        public PlayableRacesIndex(Links links, PlayableRaceReference[] races)
        {
            Links = links;
            Races = races;
        }
    }
}
