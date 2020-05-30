using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A creature.
    /// </summary>
    public class Creature
    {
        /// <summary>
        /// Gets the ID of the creature.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the creature.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the media associated with the creature.
        /// </summary>
        [JsonProperty("creature_display")]
        public Media CreatureDisplay { get; set; }
    }
}
