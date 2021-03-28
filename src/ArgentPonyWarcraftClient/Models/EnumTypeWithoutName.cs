using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An enumerated type.
    /// </summary>
    public record EnumTypeWithoutName
    {
        /// <summary>
        /// Gets the type code for this enumerated value.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumTypeWithoutName"/> class.
        /// </summary>
        /// <param name="type">The type code for this enumerated value.</param>
        [JsonConstructor]
        public EnumTypeWithoutName(string type)
        {
            Type = type;
        }
    }
}
