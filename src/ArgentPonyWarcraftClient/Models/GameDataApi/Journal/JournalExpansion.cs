using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A game expansion.
    /// </summary>
    public class JournalExpansion
    {
        /// <summary>
        /// Gets links for the expansion.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the expansion.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the expansion.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the dungeons that belong to the expansion.
        /// </summary>
        [JsonPropertyName("dungeons")]
        public InstanceReference[] Dungeons { get; set; }

        /// <summary>
        /// Gets the raids that belong to the expansion.
        /// </summary>
        [JsonPropertyName("raids")]
        public InstanceReference[] Raids { get; set; }
    }
}
