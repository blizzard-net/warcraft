using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Pet ability media.
    /// </summary>
    public class PetAbilityMedia
    {
        /// <summary>
        /// Gets links for the pet ability media.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; private set; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonProperty("assets")]
        public Asset[] Assets { get; private set; }

        /// <summary>
        /// Gets the ID of the pet ability.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
