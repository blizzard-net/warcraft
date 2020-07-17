using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A stat modifier.
    /// </summary>
    public class Stat
    {
        /// <summary>
        /// Gets the stat type.
        /// </summary>
        [JsonPropertyName("type")]
        public EnumType Type { get; set; }

        /// <summary>
        /// Gets the numerical value of the stat modifier.
        /// </summary>
        [JsonPropertyName("value")]
        public long Value { get; set; }

        /// <summary>
        /// Gets a value indicating whether the stat modifier is negated.
        /// </summary>
        [JsonPropertyName("is_negated")]
        public bool? IsNegated { get; set; }

        /// <summary>
        /// Gets the display details for the stat modifier.
        /// </summary>
        [JsonPropertyName("display")]
        public StatDisplay Display { get; set; }

        /// <summary>
        /// Gets a value indicating whether the stat modifier is an equip bonus.
        /// </summary>
        [JsonPropertyName("is_equip_bonus")]
        public bool? IsEquipBonus { get; set; }
    }
}
