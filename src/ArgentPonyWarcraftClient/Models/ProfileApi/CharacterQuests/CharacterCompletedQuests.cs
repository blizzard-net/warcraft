using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A list of quests that a character has completed.
    /// </summary>
    public class CharacterCompletedQuests
    {
        /// <summary>
        /// Gets links for the character completed quests.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonProperty("character")]
        public CharacterReference Character { get; set; }

        /// <summary>
        /// Gets references to the character's completed quests.
        /// </summary>
        [JsonProperty("quests")]
        public QuestReference[] Quests { get; set; }
    }
}
