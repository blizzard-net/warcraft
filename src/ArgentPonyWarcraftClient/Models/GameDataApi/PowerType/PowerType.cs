using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A power type.
    /// </summary>
    public class PowerType
    {
        /// <summary>
        /// Gets links for the power type.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the power type.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the power type.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
