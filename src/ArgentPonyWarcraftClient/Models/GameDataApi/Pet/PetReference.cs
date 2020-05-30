using Newtonsoft.Json;

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
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the pet.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the pet.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
