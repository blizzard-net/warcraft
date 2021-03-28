using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A conduit.
    /// </summary>
    public record Conduit
    {
        /// <summary>
        /// Gets the links for this covenant.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the Id of the conduit.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name of the conduit.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the item reference of the conduit.
        /// </summary>
        [JsonPropertyName("item")]
        public ItemReference Item { get; }

        /// <summary>
        /// Gets the socket type of the conduit.
        /// </summary>
        [JsonPropertyName("socket_type")]
        public EnumType SocketType { get; }

        /// <summary>
        /// Gets the ranks of the conduit.
        /// </summary>
        [JsonPropertyName("ranks")]
        public ConduitRank[] Ranks { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Conduit"/> class.
        /// </summary>
        /// <param name="links">The links for this covenant.</param>
        /// <param name="id">The Id of the conduit.</param>
        /// <param name="name">The name of the conduit.</param>
        /// <param name="item">The item reference of the conduit.</param>
        /// <param name="socketType">The socket type of the conduit.</param>
        /// <param name="ranks">The ranks of the conduit.</param>
        [JsonConstructor]
        public Conduit(Links links, int id, string name, ItemReference item, EnumType socketType, ConduitRank[] ranks)
        {
            Links = links;
            Id = id;
            Name = name;
            Item = item;
            SocketType = socketType;
            Ranks = ranks;
        }
    }
}
