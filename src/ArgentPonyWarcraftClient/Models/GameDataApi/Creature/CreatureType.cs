using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A creature type.
    /// </summary>
    public class CreatureType
    {
        /// <summary>
        /// Gets links for the creature type.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the creature type.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets the name of the creature type.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
