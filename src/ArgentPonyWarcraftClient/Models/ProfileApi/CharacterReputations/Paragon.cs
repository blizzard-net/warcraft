using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character's paragon status with a reputation faction.
    /// </summary>
    public class Paragon
    {
        /// <summary>
        /// Gets the raw number.
        /// </summary>
        [JsonProperty("raw")]
        public long Raw { get; set; }

        /// <summary>
        /// Gets the value.
        /// </summary>
        [JsonProperty("value")]
        public long Value { get; set; }

        /// <summary>
        /// Gets the maximum value.
        /// </summary>
        [JsonProperty("max")]
        public long Max { get; set; }
    }
}
