namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of character collections.
/// </summary>
public record CharacterCollectionsIndex
{
    /// <summary>
    /// Gets links for the character collections index.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a reference to the character's collection of pets.
    /// </summary>
    [JsonPropertyName("pets")]
    public Self Pets { get; init; }

    /// <summary>
    /// Gets a reference to the character's collection of mounts.
    /// </summary>
    [JsonPropertyName("mounts")]
    public Self Mounts { get; init; }
}
