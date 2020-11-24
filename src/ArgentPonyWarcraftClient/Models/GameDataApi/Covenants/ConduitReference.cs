using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a conduit.
    /// </summary>
    public class ConduitReference
    {
        /// <summary>
        /// Gets the key for this conduit.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the Id for this conduit.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets the name for this conduit.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
