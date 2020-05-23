using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// An index of pets.
    /// </summary>
    public class PetsIndex
    {
        /// <summary>
        /// Gets links for the index of pets.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to pets.
        /// </summary>
        [JsonProperty("pets")]
        public PetReference[] Pets { get; set; }
    }
}
