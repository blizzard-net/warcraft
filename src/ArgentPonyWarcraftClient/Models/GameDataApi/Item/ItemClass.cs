using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A category of items.
    /// </summary>
    public class ItemClass
    {
        /// <summary>
        /// Gets links for the item class.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the class ID for the item class.
        /// </summary>
        [JsonPropertyName("class_id")]
        public long ClassId { get; set; }

        /// <summary>
        /// Gets the name of the item class.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets references to the subclasses of this item class.
        /// </summary>
        [JsonPropertyName("item_subclasses")]
        public ItemSubclassReference[] ItemSubclasses { get; set; }
    }
}
