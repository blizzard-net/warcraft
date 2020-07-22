using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A creature.
    /// </summary>
    public class EncounterCreature
    {
        /// <summary>
        /// Gets the ID of the creature.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets the name of the creature.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the media associated with the creature.
        /// </summary>
        [JsonPropertyName("creature_display")]
        public Media CreatureDisplay { get; set; }
    }
}
