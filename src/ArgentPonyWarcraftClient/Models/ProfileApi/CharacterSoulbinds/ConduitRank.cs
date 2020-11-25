using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Rank details for a conduit socket.
    /// </summary>
    public class ConduitRank
    {
        /// <summary>
        /// Gets a reference to the conduit.
        /// </summary>
        [JsonPropertyName("conduit")]
        public ConduitReference Conduit { get; set; }

        /// <summary>
        /// Gets the rank of the socket.
        /// </summary>
        [JsonPropertyName("rank")]
        public long Rank { get; set; }
    }
}
