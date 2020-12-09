using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of tech talents.
    /// </summary>
    public class TechTalentsIndex
    {
        /// <summary>
        /// Gets links for the index of tech talents.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the references to the tech talents.
        /// </summary>
        [JsonPropertyName("talents")]
        public TechTalentReference[] Talents { get; set; }
    }
}
