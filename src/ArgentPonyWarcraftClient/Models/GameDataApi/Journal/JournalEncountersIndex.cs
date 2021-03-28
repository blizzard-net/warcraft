using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of boss encounters.
    /// </summary>
    public record JournalEncountersIndex
    {
        /// <summary>
        /// Gets links for the index of boss encounters.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the boss encounters.
        /// </summary>
        [JsonPropertyName("encounters")]
        public EncounterReference[] Encounters { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="JournalEncountersIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of boss encounters.</param>
        /// <param name="encounters">The boss encounters.</param>
        [JsonConstructor]
        public JournalEncountersIndex(Links links, EncounterReference[] encounters)
        {
            Links = links;
            Encounters = encounters;
        }
    }
}
