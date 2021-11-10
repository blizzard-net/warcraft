namespace ArgentPonyWarcraftClient;

/// <summary>
/// A conduit.
/// </summary>
public record Conduit
{
    /// <summary>
    /// Gets the links for this covenant.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the Id of the conduit.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the name of the conduit.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the item reference of the conduit.
    /// </summary>
    [JsonPropertyName("item")]
    public ItemReference Item { get; init; }

    /// <summary>
    /// Gets the socket type of the conduit.
    /// </summary>
    [JsonPropertyName("socket_type")]
    public EnumType SocketType { get; init; }

    /// <summary>
    /// Gets the ranks of the conduit.
    /// </summary>
    [JsonPropertyName("ranks")]
    public ConduitRank[] Ranks { get; init; }
}
