using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A title for a character.
    /// </summary>
    public class Title
    {
        /// <summary>
        /// Gets links for the title.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the title.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets the name of the title.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the gender-specific names for the title.
        /// </summary>
        [JsonPropertyName("gender_name")]
        public GenderName GenderName { get; set; }
    }
}
