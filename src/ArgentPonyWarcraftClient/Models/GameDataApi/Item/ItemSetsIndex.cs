using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of item sets.
    /// </summary>
    public class ItemSetsIndex
    {
        /// <summary>
        /// Gets links for the index of item sets.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; private set; }

        /// <summary>
        /// Gets references to item sets.
        /// </summary>
        [JsonProperty("item_sets")]
        public ItemSetReference[] ItemSets { get; set; }
    }
}
