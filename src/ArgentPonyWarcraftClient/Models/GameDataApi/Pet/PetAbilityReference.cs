using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a pet ability.
    /// </summary>
    public class PetAbilityReference
    {
        /// <summary>
        /// Gets the key for the pet ability.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the pet ability.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the pet ability.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
