using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of playable classes.
    /// </summary>
    public class PlayableClassesIndex
    {
        /// <summary>
        /// Gets links for the index of playable classes.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the playable classes.
        /// </summary>
        [JsonPropertyName("classes")]
        public PlayableClassReference[] Classes { get; set; }
    }
}
