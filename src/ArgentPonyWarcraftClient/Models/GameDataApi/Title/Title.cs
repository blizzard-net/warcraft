using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the title.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the title.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the gender-specific names for the title.
        /// </summary>
        [JsonProperty("gender_name")]
        public GenderName GenderName { get; set; }
    }
}
