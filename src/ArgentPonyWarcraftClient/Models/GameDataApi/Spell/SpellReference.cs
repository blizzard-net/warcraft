using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a spell.
    /// </summary>
    public class SpellReference
    {
        /// <summary>
        /// Gets the key for the spell.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the spell.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the spell.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
