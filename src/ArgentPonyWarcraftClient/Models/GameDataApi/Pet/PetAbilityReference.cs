using Newtonsoft.Json;

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
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the pet ability.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the pet ability.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
