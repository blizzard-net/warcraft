using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A set of quest requirements.
    /// </summary>
    public record QuestRequirements
    {
        /// <summary>
        /// Gets the minimum character level for the quest.
        /// </summary>
        [JsonPropertyName("min_character_level")]
        public int MinCharacterLevel { get; }

        /// <summary>
        /// Gets the faction for the question (Alliance or Horde).
        /// </summary>
        [JsonPropertyName("faction")]
        public EnumType Faction { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestRequirements"/> class.
        /// </summary>
        /// <param name="minCharacterLevel">The minimum character level for the quest.</param>
        /// <param name="faction">The faction for the question (Alliance or Horde).</param>
        [JsonConstructor]
        public QuestRequirements(int minCharacterLevel, EnumType faction)
        {
            MinCharacterLevel = minCharacterLevel;
            Faction = faction;
        }
    }
}
