using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A faction requirement for an item.
    /// </summary>
    public record FactionRequirement
    {
        /// <summary>
        /// Gets the faction.
        /// </summary>
        [JsonPropertyName("value")]
        public EnumType Value { get; }

        /// <summary>
        /// Gets the display string for the faction requirement.
        /// </summary>
        [JsonPropertyName("display_string")]
        public string DisplayString { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FactionRequirement"/> class.
        /// </summary>
        /// <param name="value">The faction.</param>
        /// <param name="displayString">The display string for the faction requirement.</param>
        [JsonConstructor]
        public FactionRequirement(EnumType value, string displayString)
        {
            Value = value;
            DisplayString = displayString;
        }
    }
}
