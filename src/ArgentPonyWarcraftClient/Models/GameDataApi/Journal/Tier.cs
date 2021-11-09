namespace ArgentPonyWarcraftClient;

/// <summary>
/// A tier of content.
/// </summary>
public record Tier
{
    /// <summary>
    /// Gets the key for the tier.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the tier.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the tier.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
