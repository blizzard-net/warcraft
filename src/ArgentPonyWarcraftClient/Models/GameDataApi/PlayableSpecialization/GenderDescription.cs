using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// The gender-specific description for a playable specialization.
    /// </summary>
    public record GenderDescription
    {
        /// <summary>
        /// Gets the description for male characters of a playable specialization.
        /// </summary>
        [JsonPropertyName("male")]
        public string Male { get; }

        /// <summary>
        /// Gets the description for female characters of a playable specialization.
        /// </summary>
        [JsonPropertyName("female")]
        public string Female { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenderDescription"/> class.
        /// </summary>
        /// <param name="male">The description for male characters of a playable specialization.</param>
        /// <param name="female">The description for female characters of a playable specialization.</param>
        [JsonConstructor]
        public GenderDescription(string male, string female)
        {
            Male = male;
            Female = female;
        }
    }
}
