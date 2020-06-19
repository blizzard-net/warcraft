using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An enumerated type.
    /// </summary>
    public class EnumTypeWithoutName
    {
        /// <summary>
        /// Gets the type code for this enumerated value.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
