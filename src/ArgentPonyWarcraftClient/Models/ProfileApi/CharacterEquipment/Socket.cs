using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An item socket.
    /// </summary>
    public class Socket
    {
        /// <summary>
        /// Gets the socket type.
        /// </summary>
        [JsonPropertyName("socket_type")]
        public EnumType SocketType { get; set; }

        /// <summary>
        /// Gets a reference to the item.
        /// </summary>
        [JsonPropertyName("item")]
        public ItemReference Item { get; set; }

        /// <summary>
        /// Gets the context.
        /// </summary>
        [JsonPropertyName("context")]
        public long? Context { get; set; }

        /// <summary>
        /// Gets the display string for the socket.
        /// </summary>
        [JsonPropertyName("display_string")]
        public string DisplayString { get; set; }

        /// <summary>
        /// Gets a reference to the media for the item.
        /// </summary>
        [JsonPropertyName("media")]
        public ItemMediaReference Media { get; set; }

        /// <summary>
        /// Gets a list of bonus IDs for the socket.
        /// </summary>
        [JsonPropertyName("bonus_list")]
        public long[] BonusList { get; set; }
    }
}
