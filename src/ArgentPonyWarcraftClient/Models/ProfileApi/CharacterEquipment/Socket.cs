using Newtonsoft.Json;

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
        [JsonProperty("socket_type")]
        public EnumType SocketType { get; set; }

        /// <summary>
        /// Gets a reference to the item.
        /// </summary>
        [JsonProperty("item", NullValueHandling = NullValueHandling.Ignore)]
        public ItemReference Item { get; set; }

        /// <summary>
        /// Gets the context.
        /// </summary>
        [JsonProperty("context", NullValueHandling = NullValueHandling.Ignore)]
        public long? Context { get; set; }

        /// <summary>
        /// Gets the display string for the socket.
        /// </summary>
        [JsonProperty("display_string", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayString { get; set; }

        /// <summary>
        /// Gets a reference to the media for the item.
        /// </summary>
        [JsonProperty("media", NullValueHandling = NullValueHandling.Ignore)]
        public ItemMediaReference Media { get; set; }

        /// <summary>
        /// Gets a list of bonus IDs for the socket.
        /// </summary>
        [JsonProperty("bonus_list", NullValueHandling = NullValueHandling.Ignore)]
        public long[] BonusList { get; set; }
    }
}
