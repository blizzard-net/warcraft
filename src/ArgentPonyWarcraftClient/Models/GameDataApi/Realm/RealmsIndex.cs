using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of realms.
    /// </summary>
    public class RealmsIndex
    {
        /// <summary>
        /// Gets links for the index of realms.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the realms.
        /// </summary>
        [JsonPropertyName("realms")]
        public RealmReference[] Realms { get; set; }
    }
}
