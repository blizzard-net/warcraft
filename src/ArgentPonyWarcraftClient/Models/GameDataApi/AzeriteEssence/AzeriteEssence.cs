using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An azerite essence.
    /// </summary>
    public class AzeriteEssence
    {
        /// <summary>
        /// Gets links for the azerite essence.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the azerite essence.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets the name of the azerite essence.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets references to the allowed specializations for the azerite essence.
        /// </summary>
        [JsonPropertyName("allowed_specializations")]
        public PlayableSpecializationReference[] AllowedSpecializations { get; set; }

        /// <summary>
        /// Gets the powers for the azerite essence.
        /// </summary>
        [JsonPropertyName("powers")]
        public Power[] Powers { get; set; }

        /// <summary>
        /// Gets the media associated with the azerite essence.
        /// </summary>
        [JsonPropertyName("media")]
        public Media Media { get; set; }
    }
}
