namespace ArgentPonyWarcraftClient;

/// <summary>
/// A summary of the mounts a character has obtained.
/// </summary>
public record CharacterMountsCollectionSummary
{
    /// <summary>
    /// Gets links for the character mounts collection summary.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the mounts this character has collected.
    /// </summary>
    [JsonPropertyName("mounts")]
    public CharacterMount[] Mounts { get; init; }
}
