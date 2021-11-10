namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a mythic keystone affix.
/// </summary>
public record MythicKeystoneAffixReference
{
    /// <summary>
    /// Gets the key for the keystone affix.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the keystone affix.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the keystone affix.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
