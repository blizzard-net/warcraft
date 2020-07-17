using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of creature types.
    /// </summary>
    public class CreatureTypesIndex
    {
        /// <summary>
        /// Gets links for the index of creature types.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the creature types.
        /// </summary>
        [JsonPropertyName("creature_types")]
        public CreatureTypeReference[] CreatureTypes { get; set; }
    }
}
