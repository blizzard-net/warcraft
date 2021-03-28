using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Rank details for a conduit socket.
    /// </summary>
    public record ConduitSocket
    {
        /// <summary>
        /// Gets a reference to the conduit.
        /// </summary>
        [JsonPropertyName("conduit")]
        public ConduitReference Conduit { get; }

        /// <summary>
        /// Gets the rank of the socket.
        /// </summary>
        [JsonPropertyName("rank")]
        public long Rank { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConduitSocket"/> class.
        /// </summary>
        /// <param name="conduit">A reference to the conduit.</param>
        /// <param name="rank">The rank of the socket.</param>
        [JsonConstructor]
        public ConduitSocket(ConduitReference conduit, long rank)
        {
            Conduit = conduit;
            Rank = rank;
        }
    }
}
