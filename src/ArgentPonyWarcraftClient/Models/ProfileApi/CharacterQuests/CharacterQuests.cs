using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character's active quests as well as a link to the character's completed quests.
    /// </summary>
    public record CharacterQuests
    {
        /// <summary>
        /// Gets links for the character quests.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonPropertyName("character")]
        public CharacterReference Character { get; }

        /// <summary>
        /// Gets references to the character's in-progress quests.
        /// </summary>
        [JsonPropertyName("in_progress")]
        public QuestReference[] InProgress { get; }

        /// <summary>
        /// Gets a link to the character's completed quests.
        /// </summary>
        [JsonPropertyName("completed")]
        public Self Completed { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterQuests"/> class.
        /// </summary>
        /// <param name="links">Links for the character quests.</param>
        /// <param name="character">A reference to the character.</param>
        /// <param name="inProgress">References to the character's in-progress quests.</param>
        /// <param name="completed">A link to the character's completed quests.</param>
        [JsonConstructor]
        public CharacterQuests(Links links, CharacterReference character, QuestReference[] inProgress, Self completed)
        {
            Links = links;
            Character = character;
            InProgress = inProgress;
            Completed = completed;
        }
    }
}
