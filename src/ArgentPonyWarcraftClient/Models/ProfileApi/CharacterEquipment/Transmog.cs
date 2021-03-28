using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Transmogrification details for an item.
    /// </summary>
    public class Transmog
    {
        /// <summary>
        /// Gets a reference to the item.
        /// </summary>
        [JsonPropertyName("item")]
        public ItemReference Item { get; set; }

        /// <summary>
        /// Gets the display string to describe the transmogrification.
        /// </summary>
        [JsonPropertyName("display_string")]
        public string DisplayString { get; set; }

        /// <summary>
        /// Gets the ID of the item that supplied the modified appearance.
        /// </summary>
        [JsonPropertyName("item_modified_appearance_id")]
        public int ItemModifiedAppearanceId { get; set; }
    }
}
