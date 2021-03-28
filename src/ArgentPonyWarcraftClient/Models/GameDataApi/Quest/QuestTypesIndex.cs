using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of quest types (such as PvP quests, raid quests, or account quests).
    /// </summary>
    public record QuestTypesIndex
    {
        /// <summary>
        /// Gets links for the index of quest types.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to the quest types.
        /// </summary>
        [JsonPropertyName("types")]
        public QuestTypeReference[] Types { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestTypesIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of quest types.</param>
        /// <param name="types">References to the quest types.</param>
        [JsonConstructor]
        public QuestTypesIndex(Links links, QuestTypeReference[] types)
        {
            Links = links;
            Types = types;
        }
    }
}
