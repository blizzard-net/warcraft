using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A creature family.
    /// </summary>
    public class CreatureFamily
    {
        /// <summary>
        /// Gets links for the creature family.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the creature family.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the creature family.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the specialization of the creature family.
        /// </summary>
        [JsonPropertyName("specialization")]
        public PlayableSpecializationReference Specialization { get; set; }

        /// <summary>
        /// Gets media for the creature family.
        /// </summary>
        [JsonPropertyName("media")]
        public Media Media { get; set; }
    }
}
