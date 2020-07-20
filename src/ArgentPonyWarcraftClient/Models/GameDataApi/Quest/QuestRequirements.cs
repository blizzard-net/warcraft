using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A set of quest requirements.
    /// </summary>
    public class QuestRequirements
    {
        /// <summary>
        /// Gets the minimum character level for the quest.
        /// </summary>
        [JsonPropertyName("min_character_level")]
        public long MinCharacterLevel { get; set; }

        /// <summary>
        /// Gets the faction for the question (Alliance or Horde).
        /// </summary>
        [JsonPropertyName("faction")]
        public EnumType Faction { get; set; }
    }
}
