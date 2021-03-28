using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Transmogrification details for an item.
    /// </summary>
    public record Transmog
    {
        /// <summary>
        /// Gets a reference to the item.
        /// </summary>
        [JsonPropertyName("item")]
        public ItemReference Item { get; }

        /// <summary>
        /// Gets the display string to describe the transmogrification.
        /// </summary>
        [JsonPropertyName("display_string")]
        public string DisplayString { get; }

        /// <summary>
        /// Gets the ID of the item that supplied the modified appearance.
        /// </summary>
        [JsonPropertyName("item_modified_appearance_id")]
        public int ItemModifiedAppearanceId { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Transmog"/> class.
        /// </summary>
        /// <param name="item">A reference to the item.</param>
        /// <param name="displayString">The display string to describe the transmogrification.</param>
        /// <param name="itemModifiedAppearanceId">The ID of the item that supplied the modified appearance.</param>
        [JsonConstructor]
        public Transmog(ItemReference item, string displayString, int itemModifiedAppearanceId)
        {
            Item = item;
            DisplayString = displayString;
            ItemModifiedAppearanceId = itemModifiedAppearanceId;
        }
    }
}
