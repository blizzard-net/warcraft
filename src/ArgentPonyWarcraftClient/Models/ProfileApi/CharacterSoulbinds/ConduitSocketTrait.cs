using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A conduit socket trait for a character.
    /// </summary>
    public record ConduitSocketTrait
    {
        /// <summary>
        /// Gets the type of conduit socket.
        /// </summary>
        [JsonPropertyName("type")]
        public EnumType Type { get; }

        /// <summary>
        /// Gets the socket details for the conduit.
        /// </summary>
        [JsonPropertyName("socket")]
        public ConduitSocket Socket { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConduitSocketTrait"/> class.
        /// </summary>
        /// <param name="type">The type of conduit socket.</param>
        /// <param name="socket">The socket details for the conduit.</param>
        [JsonConstructor]
        public ConduitSocketTrait(EnumType type, ConduitSocket socket)
        {
            Type = type;
            Socket = socket;
        }
    }
}
