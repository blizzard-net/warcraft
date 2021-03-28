using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of PvP talents.
    /// </summary>
    public class PvpTalentsIndex
    {
        /// <summary>
        /// Gets links for the index of PvP talents.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to PvP talents.
        /// </summary>
        [JsonPropertyName("pvp_talents")]
        public PvpTalentReference[] PvpTalents { get; set; }
    }
}
