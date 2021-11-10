namespace ArgentPonyWarcraftClient;

/// <summary>
/// The status of a player character.
/// </summary>
public record CharacterStatus
{
    /// <summary>
    /// Gets links for the character status.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the ID of the character.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets a value indicating whether the character is valid.
    /// </summary>
    [JsonPropertyName("is_valid")]
    public bool IsValid { get; init; }
}
