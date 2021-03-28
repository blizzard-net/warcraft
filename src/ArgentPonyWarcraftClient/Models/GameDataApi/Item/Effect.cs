using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A set bonus that can be activated by equipping items from the set.
    /// </summary>
    public record Effect
    {
        /// <summary>
        /// Gets the display string for the effect.
        /// </summary>
        [JsonPropertyName("display_string")]
        public string DisplayString { get; }

        /// <summary>
        /// Gets the required count of items in the set that must be equipped to activate the effect.
        /// </summary>
        [JsonPropertyName("required_count")]
        public int RequiredCount { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Effect"/> class.
        /// </summary>
        /// <param name="displayString">The display string for the effect.</param>
        /// <param name="requiredCount">The required count of items in the set that must be equipped to activate the effect.</param>
        [JsonConstructor]
        public Effect(string displayString, int requiredCount)
        {
            DisplayString = displayString;
            RequiredCount = requiredCount;
        }
    }
}
