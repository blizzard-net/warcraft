using Newtonsoft.Json;

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
        [JsonProperty("item")]
        public ItemReference Item { get; set; }

        /// <summary>
        /// Gets the display string to describe the transmogrification.
        /// </summary>
        [JsonProperty("display_string")]
        public string DisplayString { get; set; }

        /// <summary>
        /// Gets the ID of the item that supplied the modified appearance.
        /// </summary>
        [JsonProperty("item_modified_appearance_id")]
        public long ItemModifiedAppearanceId { get; set; }
    }
}
