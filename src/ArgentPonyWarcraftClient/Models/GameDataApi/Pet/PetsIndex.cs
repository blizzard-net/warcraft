using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of pets.
    /// </summary>
    public class PetsIndex
    {
        /// <summary>
        /// Gets links for the index of pets.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to pets.
        /// </summary>
        [JsonPropertyName("pets")]
        public PetReference[] Pets { get; set; }
    }
}
