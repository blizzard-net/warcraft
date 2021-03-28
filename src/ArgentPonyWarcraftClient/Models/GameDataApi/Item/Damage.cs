using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Item damage.
    /// </summary>
    public record Damage
    {
        /// <summary>
        /// Gets the minimum damage.
        /// </summary>
        [JsonPropertyName("min_value")]
        public int MinValue { get; }

        /// <summary>
        /// Gets the maximum damage.
        /// </summary>
        [JsonPropertyName("max_value")]
        public int MaxValue { get; }

        /// <summary>
        /// Gets the display string that describes the damage.
        /// </summary>
        [JsonPropertyName("display_string")]
        public string DisplayString { get; }

        /// <summary>
        /// Gets the damage class.
        /// </summary>
        [JsonPropertyName("damage_class")]
        public EnumType DamageClass { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Damage"/> class.
        /// </summary>
        /// <param name="minValue">The minimum damage.</param>
        /// <param name="maxValue">The maximum damage.</param>
        /// <param name="displayString">The display string that describes the damage.</param>
        /// <param name="damageClass">The damage class.</param>
        [JsonConstructor]
        public Damage(int minValue, int maxValue, string displayString, EnumType damageClass)
        {
            MinValue = minValue;
            MaxValue = maxValue;
            DisplayString = displayString;
            DamageClass = damageClass;
        }
    }
}
