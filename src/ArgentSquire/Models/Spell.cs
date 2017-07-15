using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// A spell.
    /// </summary>
    public class Spell
    {
        /// <summary>
        /// Gets or sets the spell ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the spell name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the icon.
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the cast time.
        /// </summary>
        [JsonProperty("castTime")]
        public string CastTime { get; set; }

        /// <summary>
        /// Gets or sets the cooldown.
        /// </summary>
        [JsonProperty("cooldown")]
        public string Cooldown { get; set; }

        /// <summary>
        /// Gets or sets the range.
        /// </summary>
        [JsonProperty("range")]
        public string Range { get; set; }

        /// <summary>
        /// Gets or sets the power cost.
        /// </summary>
        [JsonProperty("powerCost")]
        public string PowerCost { get; set; }
    }
}
