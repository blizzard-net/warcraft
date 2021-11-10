namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a reputation tier.
/// </summary>
public record ReputationTierReference
{
    /// <summary>
    /// Gets the key for the reputation tier.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the ID of the reputation tier.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the name of the reputation tier.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }
}
