using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of quest areas.
    /// </summary>
    public record QuestAreasIndex
    {
        /// <summary>
        /// Gets links for the index of quest areas.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to the quest areas.
        /// </summary>
        [JsonPropertyName("areas")]
        public QuestAreaReference[] Areas { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestAreasIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of quest areas.</param>
        /// <param name="areas">References to the quest areas.</param>
        [JsonConstructor]
        public QuestAreasIndex(Links links, QuestAreaReference[] areas)
        {
            Links = links;
            Areas = areas;
        }
    }
}
