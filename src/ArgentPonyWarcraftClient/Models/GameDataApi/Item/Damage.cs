using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// Item damage.
    /// </summary>
    public class Damage
    {
        /// <summary>
        /// Gets the minimum damage.
        /// </summary>
        [JsonProperty("min_value")]
        public long MinValue { get; set; }

        /// <summary>
        /// Gets the maximum damage.
        /// </summary>
        [JsonProperty("max_value")]
        public long MaxValue { get; set; }

        /// <summary>
        /// Gets the display string that describes the damage.
        /// </summary>
        [JsonProperty("display_string")]
        public string DisplayString { get; set; }

        /// <summary>
        /// Gets the damage class.
        /// </summary>
        [JsonProperty("damage_class")]
        public EnumType DamageClass { get; set; }
    }
}
