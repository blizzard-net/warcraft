using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A subcategory of items.
    /// </summary>
    public record ItemSubclass
    {
        /// <summary>
        /// Gets links for the item subclass.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the class ID for the item class.
        /// </summary>
        [JsonPropertyName("class_id")]
        public int ClassId { get; }

        /// <summary>
        /// Gets the subclass ID for the item subclass.
        /// </summary>
        [JsonPropertyName("subclass_id")]
        public int SubclassId { get; }

        /// <summary>
        /// Gets the display name of the item subclass.
        /// </summary>
        [JsonPropertyName("display_name")]
        public string DisplayName { get; }

        /// <summary>
        /// Gets a value indicating whether the subclass is hidden in tooltips.
        /// </summary>
        [JsonPropertyName("hide_subclass_in_tooltips")]
        public bool HideSubclassInTooltips { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemSubclass"/> class.
        /// </summary>
        /// <param name="links">Links for the item subclass.</param>
        /// <param name="classId">The class ID for the item class.</param>
        /// <param name="subclassId">The subclass ID for the item subclass.</param>
        /// <param name="displayName">The display name of the item subclass.</param>
        /// <param name="hideSubclassInTooltips">A value indicating whether the subclass is hidden in tooltips.</param>
        [JsonConstructor]
        public ItemSubclass(Links links, int classId, int subclassId, string displayName, bool hideSubclassInTooltips)
        {
            Links = links;
            ClassId = classId;
            SubclassId = subclassId;
            DisplayName = displayName;
            HideSubclassInTooltips = hideSubclassInTooltips;
        }
    }
}
