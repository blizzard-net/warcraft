using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A conduit.
    /// </summary>
    public class Conduit
    {
        /// <summary>
        /// Gets the links for this covenant.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the Id of the conduit.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets the name of the conduit.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the item reference of the conduit.
        /// </summary>
        [JsonPropertyName("item")]
        public ItemReference Item { get; set; }

        /// <summary>
        /// Gets the socket type of the conduit.
        /// </summary>
        [JsonPropertyName("socket_type")]
        public EnumType SocketType { get; set; }

        /// <summary>
        /// Gets the ranks of the conduit.
        /// </summary>
        [JsonPropertyName("ranks")]
        public ConduitRank[] Ranks { get; set; }
    }
}
