namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of soulbinds.
/// </summary>
public record SoulbindsIndex
{
    /// <summary>
    /// Gets the links for the index of soulbinds.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the soulbind references.
    /// </summary>
    [JsonPropertyName("soulbinds")]
    public SoulbindReference[] Soulbinds { get; init; }
}
