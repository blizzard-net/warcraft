namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a Mythic Keystone season.
/// </summary>
public record MythicKeystoneSeasonReference
{
    /// <summary>
    /// Gets the key for the Mythic Keystone season.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the ID of the Mythic Keystone season.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
