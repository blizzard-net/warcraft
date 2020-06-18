using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of character collections.
    /// </summary>
    public class CharacterCollectionsIndex
    {
        /// <summary>
        /// Gets links for the character collections index.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a reference to the character's collection of pets.
        /// </summary>
        [JsonProperty("pets")]
        public Self Pets { get; set; }

        /// <summary>
        /// Gets a reference to the character's collection of mounts.
        /// </summary>
        [JsonProperty("mounts")]
        public Self Mounts { get; set; }
    }
}
