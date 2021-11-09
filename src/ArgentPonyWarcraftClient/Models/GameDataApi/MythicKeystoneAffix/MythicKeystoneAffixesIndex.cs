namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of mythic keystone affixes.
/// </summary>
public record MythicKeystoneAffixesIndex
{
    /// <summary>
    /// Gets links for the index of mythic keystone affixes.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets references to the mythic keystone affixes.
    /// </summary>
    [JsonPropertyName("affixes")]
    public MythicKeystoneAffixReference[] Affixes { get; init; }
}
