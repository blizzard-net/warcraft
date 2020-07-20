using System.Text.Json.Serialization;

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
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
