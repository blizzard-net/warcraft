using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// The category of the instance (i.e., "DUNGEON" or "RAID").
    /// </summary>
    public record InstanceCategory
    {
        /// <summary>
        /// Gets the type of the instance category.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceCategory"/> class.
        /// </summary>
        /// <param name="type">The type of the instance category.</param>
        [JsonConstructor]
        public InstanceCategory(string type)
        {
            Type = type;
        }
    }
}
