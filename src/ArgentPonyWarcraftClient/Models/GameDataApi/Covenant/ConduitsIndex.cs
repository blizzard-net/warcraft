using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of conduits.
    /// </summary>
    public class ConduitsIndex
    {
        /// <summary>
        /// Gets the links for the index of conduits.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the conduit references.
        /// </summary>
        [JsonPropertyName("conduits")]
        public ConduitReference[] Conduits { get; set; }
    }
}
