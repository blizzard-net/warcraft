using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of talents.
    /// </summary>
    public class TalentsIndex
    {
        /// <summary>
        /// Gets links for the index of talents.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to talents.
        /// </summary>
        [JsonPropertyName("talents")]
        public TalentReference[] Talents { get; set; }
    }
}
