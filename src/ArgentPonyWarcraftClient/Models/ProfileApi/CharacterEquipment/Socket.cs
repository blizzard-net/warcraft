using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An item socket.
    /// </summary>
    public record Socket
    {
        /// <summary>
        /// Gets the socket type.
        /// </summary>
        [JsonPropertyName("socket_type")]
        public EnumType SocketType { get; }

        /// <summary>
        /// Gets a reference to the item.
        /// </summary>
        [JsonPropertyName("item")]
        public ItemReference Item { get; }

        /// <summary>
        /// Gets the context.
        /// </summary>
        [JsonPropertyName("context")]
        public int? Context { get; }

        /// <summary>
        /// Gets the display string for the socket.
        /// </summary>
        [JsonPropertyName("display_string")]
        public string DisplayString { get; }

        /// <summary>
        /// Gets a reference to the media for the item.
        /// </summary>
        [JsonPropertyName("media")]
        public ItemMediaReference Media { get; }

        /// <summary>
        /// Gets a list of bonus IDs for the socket.
        /// </summary>
        [JsonPropertyName("bonus_list")]
        public int[] BonusList { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Socket"/> class.
        /// </summary>
        /// <param name="socketType">The socket type.</param>
        /// <param name="item">A reference to the item.</param>
        /// <param name="context">The context.</param>
        /// <param name="displayString">The display string for the socket.</param>
        /// <param name="media">A reference to the media for the item.</param>
        /// <param name="bonusList">A list of bonus IDs for the socket.</param>
        [JsonConstructor]
        public Socket(EnumType socketType, ItemReference item, int? context, string displayString, ItemMediaReference media, int[] bonusList)
        {
            SocketType = socketType;
            Item = item;
            Context = context;
            DisplayString = displayString;
            Media = media;
            BonusList = bonusList;
        }
    }
}
