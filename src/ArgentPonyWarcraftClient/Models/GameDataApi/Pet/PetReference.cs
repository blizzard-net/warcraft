using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a pet.
    /// </summary>
    public class PetReference
    {
        /// <summary>
        /// Gets the key for the pet.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the pet.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the pet.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
