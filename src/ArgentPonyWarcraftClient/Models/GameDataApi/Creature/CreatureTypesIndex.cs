using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the creature types.
        /// </summary>
        [JsonProperty("creature_types")]
        public CreatureTypeReference[] CreatureTypes { get; set; }
    }
}
