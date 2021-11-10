namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a Mythic Keystone period.
/// </summary>
public record MythicKeystonePeriodReference
{
    /// <summary>
    /// Gets the key for the Mythic Keystone period.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the ID of the Mythic Keystone period.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
