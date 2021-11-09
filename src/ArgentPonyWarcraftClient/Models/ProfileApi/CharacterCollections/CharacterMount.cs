namespace ArgentPonyWarcraftClient;

/// <summary>
/// A specific mount that has been collected by a character.
/// </summary>
public record CharacterMount
{
    /// <summary>
    /// Gets a reference to the type of mount.
    /// </summary>
    [JsonPropertyName("mount")]
    public MountReference Mount { get; init; }

    /// <summary>
    /// Gets a value indicating whether this mount is a favorite for the character.
    /// </summary>
    [JsonPropertyName("is_favorite")]
    public bool? IsFavorite { get; init; }
}
