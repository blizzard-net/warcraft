namespace ArgentPonyWarcraftClient;

/// <summary>
/// A PvP bracket.
/// </summary>
public record Bracket
{
    /// <summary>
    /// Gets the ID of the PvP bracket.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the type of the PvP bracket.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; init; }
}
