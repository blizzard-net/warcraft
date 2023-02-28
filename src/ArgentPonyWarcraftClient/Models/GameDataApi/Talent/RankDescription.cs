namespace ArgentPonyWarcraftClient;

/// <summary>
/// A talent rank description.
/// </summary>
public record RankDescription
{
    /// <summary>
    /// Gets the numeric rank.
    /// </summary>
    [JsonPropertyName("rank")]
    public int Rank { get; init; }

    /// <summary>
    /// Gets the rank description.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; init; }
}
