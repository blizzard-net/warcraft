using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A quest type (such as PvP quests, raid quests, or account quests).
    /// </summary>
    public record QuestType
    {
        /// <summary>
        /// Gets links for the quest type.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the quest type.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the quest type name.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; }

        /// <summary>
        /// Gets references to the quests of this type.
        /// </summary>
        [JsonPropertyName("quests")]
        public QuestReference[] Quests { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestType"/> class.
        /// </summary>
        /// <param name="links">Links for the quest type.</param>
        /// <param name="id">The ID of the quest type.</param>
        /// <param name="type">The quest type name.</param>
        /// <param name="quests">References to the quests of this type.</param>
        [JsonConstructor]
        public QuestType(Links links, int id, string type, QuestReference[] quests)
        {
            Links = links;
            Id = id;
            Type = type;
            Quests = quests;
        }
    }
}
