namespace ArgentPonyWarcraftClient;

/// <summary>
/// A mythic keystone upgrade.
/// </summary>
public record MythicKeystoneUpgrade
{
    /// <summary>
    /// Gets the upgrade level.
    /// </summary>
    [JsonPropertyName("upgrade_level")]
    public int UpgradeLevel { get; init; }

    /// <summary>
    /// Gets the qualifying duration.
    /// </summary>
    [JsonPropertyName("qualifying_duration")]
    public TimeSpan QualifyingDuration { get; init; }
}
