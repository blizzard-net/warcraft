namespace ArgentPonyWarcraftClient;

/// <summary>
/// Rank details for a conduit socket.
/// </summary>
public record ConduitSocket
{
    /// <summary>
    /// Gets a reference to the conduit.
    /// </summary>
    [JsonPropertyName("conduit")]
    public ConduitReference Conduit { get; init; }

    /// <summary>
    /// Gets the rank of the socket.
    /// </summary>
    [JsonPropertyName("rank")]
    public long Rank { get; init; }
}
