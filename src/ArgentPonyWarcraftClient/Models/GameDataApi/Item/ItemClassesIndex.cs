using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of item classes.
    /// </summary>
    public record ItemClassesIndex
    {
        /// <summary>
        /// Gets links for the index of item classes.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to item classes.
        /// </summary>
        [JsonPropertyName("item_classes")]
        public ItemClassReference[] ItemClasses { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemClassesIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of item classes.</param>
        /// <param name="itemClasses">References to item classes.</param>
        [JsonConstructor]
        public ItemClassesIndex(Links links, ItemClassReference[] itemClasses)
        {
            Links = links;
            ItemClasses = itemClasses;
        }
    }
}
