namespace ArgentPonyWarcraftClient;

/// <summary>
/// An item socket.
/// </summary>
public record Socket
{
    /// <summary>
    /// Gets the socket type.
    /// </summary>
    [JsonPropertyName("socket_type")]
    public EnumType SocketType { get; init; }

    /// <summary>
    /// Gets a reference to the item.
    /// </summary>
    [JsonPropertyName("item")]
    public ItemReference Item { get; init; }

    /// <summary>
    /// Gets the context.
    /// </summary>
    [JsonPropertyName("context")]
    public int? Context { get; init; }

    /// <summary>
    /// Gets the display string for the socket.
    /// </summary>
    [JsonPropertyName("display_string")]
    public string DisplayString { get; init; }

    /// <summary>
    /// Gets a reference to the media for the item.
    /// </summary>
    [JsonPropertyName("media")]
    public ItemMediaReference Media { get; init; }

    /// <summary>
    /// Gets a list of bonus IDs for the socket.
    /// </summary>
    [JsonPropertyName("bonus_list")]
    public int[] BonusList { get; init; }
}
