using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character race.
    /// </summary>
    public class CharacterRace
    {
        /// <summary>
        /// Gets or sets the race ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the mask.
        /// </summary>
        [JsonProperty("mask")]
        public int Mask { get; set; }

        /// <summary>
        /// Gets or sets the side.
        /// </summary>
        [JsonProperty("side")]
        public string Side { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
