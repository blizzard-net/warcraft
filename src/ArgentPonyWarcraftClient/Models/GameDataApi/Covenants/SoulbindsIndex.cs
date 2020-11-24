using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of soulbinds.
    /// </summary>
    public class SoulbindsIndex
    {
        /// <summary>
        /// Gets the links for the index of soulbinds.
        /// </summary>
        [JsonPropertyName("links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the soulbind references.
        /// </summary>
        [JsonPropertyName("soulbinds")]
        public SoulbindReference[] Soulbinds { get; set; }
    }
}
