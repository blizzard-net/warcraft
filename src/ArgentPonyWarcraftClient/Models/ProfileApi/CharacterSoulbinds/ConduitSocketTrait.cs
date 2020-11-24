using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A conduit socket trait for a character.
    /// </summary>
    public class ConduitSocketTrait
    {
        /// <summary>
        /// Gets the type of conduit socket.
        /// </summary>
        [JsonPropertyName("type")]
        public EnumType Type { get; set; }

        /// <summary>
        /// Gets the socket details for the conduit.
        /// </summary>
        [JsonPropertyName("socket")]
        public ConduitRank Socket { get; set; }
    }
}
