using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Item damage.
    /// </summary>
    public class Damage
    {
        /// <summary>
        /// Gets the minimum damage.
        /// </summary>
        [JsonPropertyName("min_value")]
        public int MinValue { get; set; }

        /// <summary>
        /// Gets the maximum damage.
        /// </summary>
        [JsonPropertyName("max_value")]
        public int MaxValue { get; set; }

        /// <summary>
        /// Gets the display string that describes the damage.
        /// </summary>
        [JsonPropertyName("display_string")]
        public string DisplayString { get; set; }

        /// <summary>
        /// Gets the damage class.
        /// </summary>
        [JsonPropertyName("damage_class")]
        public EnumType DamageClass { get; set; }
    }
}
