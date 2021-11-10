namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to azerite essence media.
/// </summary>
public record AzeritEssenceMediaReference
{
    /// <summary>
    /// Gets the key for the azerite essence media.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the ID of the azerite essence.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
