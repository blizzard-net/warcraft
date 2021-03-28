using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a character title.
    /// </summary>
    public record TitleReferenceWithDisplayString
    {
        /// <summary>
        /// Gets the key for the title.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the title.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the title.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the display string for the title.
        /// </summary>
        [JsonPropertyName("display_string")]
        public string DisplayString { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TitleReferenceWithDisplayString"/> class.
        /// </summary>
        /// <param name="key">The key for the title.</param>
        /// <param name="name">The name of the title.</param>
        /// <param name="id">The ID of the title.</param>
        /// <param name="displayString">The display string for the title.</param>
        [JsonConstructor]
        public TitleReferenceWithDisplayString(Self key, string name, int id, string displayString)
        {
            Key = key;
            Name = name;
            Id = id;
            DisplayString = displayString;
        }
    }
}
