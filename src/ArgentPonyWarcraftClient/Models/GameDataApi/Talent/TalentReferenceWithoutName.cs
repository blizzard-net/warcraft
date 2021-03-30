using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a talent.
    /// </summary>
    public record TalentReferenceWithoutName
    {
        /// <summary>
        /// Gets the key for the talent.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; init; }

        /// <summary>
        /// Gets the ID of the talent.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; init; }
    }
}
