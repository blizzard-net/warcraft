namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a soulbind.
/// </summary>
public record SoulbindReference
{
    /// <summary>
    /// Gets the key for the soulbind.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the soulbind.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the soulbind.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
