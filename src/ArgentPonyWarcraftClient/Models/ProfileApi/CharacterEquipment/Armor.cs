using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Armor details for an item.
    /// </summary>
    public class Armor
    {
        /// <summary>
        /// Gets the number of armor points for the item.
        /// </summary>
        [JsonPropertyName("value")]
        public long Value { get; set; }

        /// <summary>
        /// Gets a display information for the armor.
        /// </summary>
        [JsonPropertyName("display")]
        public NameDescription Display { get; set; }
    }
}
