using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.Community
{
    /// <summary>
    /// A modifier.
    /// </summary>
    public class Modifier
    {
        /// <summary>
        /// Gets or sets the modifier type.
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }

        /// <summary>
        /// Gets or sets the modifier value.
        /// </summary>
        [JsonProperty("value")]
        public int Value { get; set; }
    }
}
