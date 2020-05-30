using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// A category of items.
    /// </summary>
    public class ItemClass
    {
        /// <summary>
        /// Gets links for the item class.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the class ID for the item class.
        /// </summary>
        [JsonProperty("class_id")]
        public long ClassId { get; set; }

        /// <summary>
        /// Gets the name of the item class.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets references to the subclasses of this item class.
        /// </summary>
        [JsonProperty("item_subclasses")]
        public ItemSubclassReference[] ItemSubclasses { get; set; }
    }
}
