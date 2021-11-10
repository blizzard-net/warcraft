namespace ArgentPonyWarcraftClient;

/// <summary>
/// Requirements for using a mount.
/// </summary>
public record MountRequirements
{
    /// <summary>
    /// Gets the required faction for the mount.
    /// </summary>
    [JsonPropertyName("faction")]
    public EnumType Faction { get; init; }
}
