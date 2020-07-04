using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A hunter pet.
    /// </summary>
    public class HunterPet
    {
        /// <summary>
        /// Gets the name of the hunter pet.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the level of the hunter pet.
        /// </summary>
        [JsonProperty("level")]
        public long Level { get; set; }

        /// <summary>
        /// Gets a reference to the creature type of the hunter pet.
        /// </summary>
        [JsonProperty("creature")]
        public CreatureReference Creature { get; set; }

        /// <summary>
        /// Gets the slot to which the hunter pet is assigned.
        /// </summary>
        [JsonProperty("slot")]
        public long Slot { get; set; }

        /// <summary>
        /// Gets a value indicating whether the hunter pet is active.
        /// </summary>
        [JsonProperty("is_active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets a reference to creature display media for the hunter pet.
        /// </summary>
        [JsonProperty("creature_display")]
        public CreatureDisplayMediaReference CreatureDisplay { get; set; }

        /// <summary>
        /// Gets a value indicating whether the hunter pet is summoned.
        /// </summary>
        [JsonProperty("is_summoned", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSummoned { get; set; }
    }
}
