using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An enumerated type.
    /// </summary>
    public record EnumType
    {
        /// <summary>
        /// Gets the type code for this enumerated value.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; }

        /// <summary>
        /// Gets the name of the enumerated value.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumType"/> class.
        /// </summary>
        /// <param name="type">The type code for this enumerated value.</param>
        /// <param name="name">The name of the enumerated value.</param>
        [JsonConstructor]
        public EnumType(string type, string name)
        {
            Type = type;
            Name = name;
        }
    }
}
