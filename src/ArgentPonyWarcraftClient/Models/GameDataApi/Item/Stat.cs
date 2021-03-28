using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A stat modifier.
    /// </summary>
    public record Stat
    {
        /// <summary>
        /// Gets the stat type.
        /// </summary>
        [JsonPropertyName("type")]
        public EnumType Type { get; }

        /// <summary>
        /// Gets the numerical value of the stat modifier.
        /// </summary>
        [JsonPropertyName("value")]
        public int Value { get; }

        /// <summary>
        /// Gets a value indicating whether the stat modifier is negated.
        /// </summary>
        [JsonPropertyName("is_negated")]
        public bool? IsNegated { get; }

        /// <summary>
        /// Gets the display details for the stat modifier.
        /// </summary>
        [JsonPropertyName("display")]
        public StatDisplay Display { get; }

        /// <summary>
        /// Gets a value indicating whether the stat modifier is an equip bonus.
        /// </summary>
        [JsonPropertyName("is_equip_bonus")]
        public bool? IsEquipBonus { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Stat"/> class.
        /// </summary>
        /// <param name="type">The stat type.</param>
        /// <param name="value">The numerical value of the stat modifier.</param>
        /// <param name="isNegated">A value indicating whether the stat modifier is negated.</param>
        /// <param name="display">The display details for the stat modifier.</param>
        /// <param name="isEquipBonus">A value indicating whether the stat modifier is an equip bonus.</param>
        [JsonConstructor]
        public Stat(EnumType type, int value, bool? isNegated, StatDisplay display, bool? isEquipBonus)
        {
            Type = type;
            Value = value;
            IsNegated = isNegated;
            Display = display;
            IsEquipBonus = isEquipBonus;
        }
    }
}
