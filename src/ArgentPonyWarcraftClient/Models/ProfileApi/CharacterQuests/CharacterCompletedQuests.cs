using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A list of quests that a character has completed.
    /// </summary>
    public record CharacterCompletedQuests
    {
        /// <summary>
        /// Gets links for the character completed quests.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonPropertyName("character")]
        public CharacterReference Character { get; }

        /// <summary>
        /// Gets references to the character's completed quests.
        /// </summary>
        [JsonPropertyName("quests")]
        public QuestReference[] Quests { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterCompletedQuests"/> class.
        /// </summary>
        /// <param name="links">Links for the character completed quests.</param>
        /// <param name="character">A reference to the character.</param>
        /// <param name="quests">References to the character's completed quests.</param>
        [JsonConstructor]
        public CharacterCompletedQuests(Links links, CharacterReference character, QuestReference[] quests)
        {
            Links = links;
            Character = character;
            Quests = quests;
        }
    }
}
