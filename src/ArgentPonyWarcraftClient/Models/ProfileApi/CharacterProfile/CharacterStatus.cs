using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// The status of a player character.
    /// </summary>
    public class CharacterStatus
    {
        /// <summary>
        /// Gets links for the character status.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the character.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets a value indicating whether the character is valid.
        /// </summary>
        [JsonProperty("is_valid")]
        public bool IsValid { get; set; }
    }
}
