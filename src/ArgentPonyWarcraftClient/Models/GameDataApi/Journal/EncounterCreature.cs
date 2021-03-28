using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A creature.
    /// </summary>
    public record EncounterCreature
    {
        /// <summary>
        /// Gets the ID of the creature.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name of the creature.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the media associated with the creature.
        /// </summary>
        [JsonPropertyName("creature_display")]
        public Media CreatureDisplay { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EncounterCreature"/> class.
        /// </summary>
        /// <param name="id">The ID of the creature.</param>
        /// <param name="name">The name of the creature.</param>
        /// <param name="creatureDisplay">The media associated with the creature.</param>
        [JsonConstructor]
        public EncounterCreature(int id, string name, Media creatureDisplay)
        {
            Id = id;
            Name = name;
            CreatureDisplay = creatureDisplay;
        }
    }
}
