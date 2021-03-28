using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A category of items.
    /// </summary>
    public record ItemClass
    {
        /// <summary>
        /// Gets links for the item class.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the class ID for the item class.
        /// </summary>
        [JsonPropertyName("class_id")]
        public int ClassId { get; }

        /// <summary>
        /// Gets the name of the item class.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets references to the subclasses of this item class.
        /// </summary>
        [JsonPropertyName("item_subclasses")]
        public ItemSubclassReference[] ItemSubclasses { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemClass"/> class.
        /// </summary>
        /// <param name="links">Links for the item class.</param>
        /// <param name="classId">The class ID for the item class.</param>
        /// <param name="name">The name of the item class.</param>
        /// <param name="itemSubclasses">References to the subclasses of this item class.</param>
        [JsonConstructor]
        public ItemClass(Links links, int classId, string name, ItemSubclassReference[] itemSubclasses)
        {
            Links = links;
            ClassId = classId;
            Name = name;
            ItemSubclasses = itemSubclasses;
        }
    }
}
