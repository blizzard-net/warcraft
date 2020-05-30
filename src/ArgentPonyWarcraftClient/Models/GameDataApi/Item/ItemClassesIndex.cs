using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of item classes.
    /// </summary>
    public class ItemClassesIndex
    {
        /// <summary>
        /// Gets links for the index of item classes.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; private set; }

        /// <summary>
        /// Gets references to item classes.
        /// </summary>
        [JsonProperty("item_classes")]
        public ItemClassReference[] ItemClasses { get; private set; }
    }
}
