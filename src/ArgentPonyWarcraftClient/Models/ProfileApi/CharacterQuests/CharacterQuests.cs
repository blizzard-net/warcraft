using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character's active quests as well as a link to the character's completed quests.
    /// </summary>
    public class CharacterQuests
    {
        /// <summary>
        /// Gets links for the character quests.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonProperty("character")]
        public CharacterReference Character { get; set; }

        /// <summary>
        /// Gets references to the character's in-progress quests.
        /// </summary>
        [JsonProperty("in_progress")]
        public QuestReference[] InProgress { get; set; }

        /// <summary>
        /// Gets a link to the character's completed quests.
        /// </summary>
        [JsonProperty("completed")]
        public Self Completed { get; set; }
    }
}
