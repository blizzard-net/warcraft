namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a covenant reward.
/// </summary>
public record CovenantRewardReference
{
    /// <summary>
    /// Gets the key for the covenant reward.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name for the covenant reward.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the Id for the covenant reward.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
