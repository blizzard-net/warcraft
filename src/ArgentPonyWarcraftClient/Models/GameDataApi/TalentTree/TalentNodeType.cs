namespace ArgentPonyWarcraftClient;

/// <summary>
/// Represents the type of a talent node.
/// </summary>
public record TalentNodeType
{
    /// <summary>
    /// Gets the ID of the talent node type.
    /// </summary>
    [JsonPropertyName("id")]
    public long Id { get; init; }

    /// <summary>
    /// Gets the type of the talent node.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; init; }
}
