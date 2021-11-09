namespace ArgentPonyWarcraftClient;

/// <summary>
/// A mythic keystone affix and starting level.
/// </summary>
public record LeaderboardKeystoneAffix
{
    /// <summary>
    /// Gets a reference to a mythic keystone affix.
    /// </summary>
    [JsonPropertyName("keystone_affix")]
    public MythicKeystoneAffixReference KeystoneAffix { get; init; }

    /// <summary>
    /// Gets the starting level for the mythic keystone affix.
    /// </summary>
    [JsonPropertyName("starting_level")]
    public int StartingLevel { get; init; }
}
