using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of item sets.
    /// </summary>
    public record ItemSetsIndex
    {
        /// <summary>
        /// Gets links for the index of item sets.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to item sets.
        /// </summary>
        [JsonPropertyName("item_sets")]
        public ItemSetReference[] ItemSets { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemSetsIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of item sets.</param>
        /// <param name="itemSets">References to item sets.</param>
        [JsonConstructor]
        public ItemSetsIndex(Links links, ItemSetReference[] itemSets)
        {
            Links = links;
            ItemSets = itemSets;
        }
    }
}
