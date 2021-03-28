using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a character title.
    /// </summary>
    public class TitleReferenceWithDisplayString
    {
        /// <summary>
        /// Gets the key for the title.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the title.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the title.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets the display string for the title.
        /// </summary>
        [JsonPropertyName("display_string")]
        public string DisplayString { get; set; }
    }
}
