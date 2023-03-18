namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to talent tree media.
/// </summary>
public record TalentTreeMediaReference
{
    /// <summary>
    /// Gets the key for the talent tree media.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }
}
