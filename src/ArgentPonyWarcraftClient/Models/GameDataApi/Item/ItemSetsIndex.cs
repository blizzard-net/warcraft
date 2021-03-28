using System.Text.Json.Serialization;

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
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to item sets.
        /// </summary>
        [JsonPropertyName("item_sets")]
        public ItemSetReference[] ItemSets { get; set; }
    }
}
