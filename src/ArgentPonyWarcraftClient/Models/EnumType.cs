using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An enumerated type.
    /// </summary>
    public class EnumType
    {
        /// <summary>
        /// Gets the type code for this enumerated value.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets the name of the enumerated value.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
