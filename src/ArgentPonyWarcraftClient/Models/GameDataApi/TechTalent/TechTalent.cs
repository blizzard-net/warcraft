using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A tech talent.
    /// </summary>
    public class TechTalent
    {
        /// <summary>
        /// Gets links for the tech talent.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the Id for the tech talent.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets the tech talent tree reference for the tech talent.
        /// </summary>
        [JsonPropertyName("talent_tree")]
        public TechTalentTreeReference TalentTree { get; set; }

        /// <summary>
        /// Gets the name for the tech talent.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the tier for the tech talent.
        /// </summary>
        [JsonPropertyName("tier")]
        public int Tier { get; set; }

        /// <summary>
        /// Gets the display order for the tech talent.
        /// </summary>
        [JsonPropertyName("display_order")]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Gets the media for the tech talent.
        /// </summary>
        [JsonPropertyName("media")]
        public Media Media { get; set; }
    }
}
