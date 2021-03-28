using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Armor details for an item.
    /// </summary>
    public record Armor
    {
        /// <summary>
        /// Gets the number of armor points for the item.
        /// </summary>
        [JsonPropertyName("value")]
        public int Value { get; }

        /// <summary>
        /// Gets a display information for the armor.
        /// </summary>
        [JsonPropertyName("display")]
        public NameDescription Display { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Armor"/> class.
        /// </summary>
        /// <param name="value">The number of armor points for the item.</param>
        /// <param name="display">A display information for the armor.</param>
        [JsonConstructor]
        public Armor(int value, NameDescription display)
        {
            Value = value;
            Display = display;
        }
    }
}
