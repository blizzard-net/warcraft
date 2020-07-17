using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A creature.
    /// </summary>
    public class Creature
    {
        /// <summary>
        /// Gets links for the creature.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the creature.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the creature.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the type of the creature.
        /// </summary>
        [JsonPropertyName("type")]
        public CreatureTypeReference Type { get; set; }

        /// <summary>
        /// Gets the family of the creature.
        /// </summary>
        [JsonPropertyName("family")]
        public CreatureFamilyReference Family { get; set; }

        /// <summary>
        /// Gets the creature display media for this creature.
        /// </summary>
        [JsonPropertyName("creature_displays")]
        public Media[] CreatureDisplays { get; set; }

        /// <summary>
        /// Gets a value indicating whether the creature can be tamed.
        /// </summary>
        [JsonPropertyName("is_tameable")]
        public bool IsTameable { get; set; }
    }
}
