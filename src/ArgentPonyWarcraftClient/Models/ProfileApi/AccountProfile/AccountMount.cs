namespace ArgentPonyWarcraftClient;

/// <summary>
/// A mount belonging to a World of Warcraft account.
/// </summary>
public record AccountMount
{
    /// <summary>
    /// Gets a reference to the mount.
    /// </summary>
    [JsonPropertyName("mount")]
    public MountReference Mount { get; init; }

    /// <summary>
    /// Gets a value indicating whether the mount is a favorite.
    /// </summary>
    [JsonPropertyName("is_favorite")]
    public bool? IsFavorite { get; init; }
}
