namespace ArgentPonyWarcraftClient;

/// <summary>
/// A conduit socket trait for a character.
/// </summary>
public record ConduitSocketTrait
{
    /// <summary>
    /// Gets the type of conduit socket.
    /// </summary>
    [JsonPropertyName("type")]
    public EnumType Type { get; init; }

    /// <summary>
    /// Gets the socket details for the conduit.
    /// </summary>
    [JsonPropertyName("socket")]
    public ConduitSocket Socket { get; init; }
}
