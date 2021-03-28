using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// The gender-specific names for a playable class, race, or title.
    /// </summary>
    public record GenderName
    {
        /// <summary>
        /// Gets the name for male characters.
        /// </summary>
        [JsonPropertyName("male")]
        public string Male { get; }

        /// <summary>
        /// Gets the name for female characters.
        /// </summary>
        [JsonPropertyName("female")]
        public string Female { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenderName"/> class.
        /// </summary>
        /// <param name="male">The name for male characters.</param>
        /// <param name="female">The name for female characters.</param>
        [JsonConstructor]
        public GenderName(string male, string female)
        {
            Male = male;
            Female = female;
        }
    }
}
