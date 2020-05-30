using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// A stat modifier.
    /// </summary>
    public class Stat
    {
        /// <summary>
        /// Gets the stat type.
        /// </summary>
        [JsonProperty("type")]
        public EnumType Type { get; set; }

        /// <summary>
        /// Gets the numerical value of the stat modifier.
        /// </summary>
        [JsonProperty("value")]
        public long Value { get; set; }

        /// <summary>
        /// Gets a value indicating whether the stat modifier is negated.
        /// </summary>
        [JsonProperty("is_negated", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsNegated { get; set; }

        /// <summary>
        /// Gets the display details for the stat modifier.
        /// </summary>
        [JsonProperty("display")]
        public StatDisplay Display { get; set; }
    }
}
