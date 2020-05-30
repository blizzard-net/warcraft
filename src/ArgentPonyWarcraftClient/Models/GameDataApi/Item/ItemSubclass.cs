using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// A subcategory of items.
    /// </summary>
    public class ItemSubclass
    {
        /// <summary>
        /// Gets links for the item subclass.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the class ID for the item class.
        /// </summary>
        [JsonProperty("class_id")]
        public long ClassId { get; set; }

        /// <summary>
        /// Gets the subclass ID for the item subclass.
        /// </summary>
        [JsonProperty("subclass_id")]
        public long SubclassId { get; set; }

        /// <summary>
        /// Gets the display name of the item subclass.
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets a value indicating whether the subclass is hidden in tooltips.
        /// </summary>
        [JsonProperty("hide_subclass_in_tooltips")]
        public bool HideSubclassInTooltips { get; set; }
    }
}
