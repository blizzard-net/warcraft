namespace ArgentPonyWarcraftClient;

/// <summary>
/// A protected profile summary for a character.
/// </summary>
public record ProtectedCharacterProfileSummary
{
    /// <summary>
    /// Gets links for the protected profile summary for the character.
    /// </summary>
    [JsonPropertyName("_links")]
    public LinksForAccountProfile Links { get; init; }

    /// <summary>
    /// Gets the ID of the character.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the name of the character.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the amount of money owned by the character.
    /// </summary>
    [JsonPropertyName("money")]
    public long Money { get; init; }

    /// <summary>
    /// Gets a reference to the character.
    /// </summary>
    [JsonPropertyName("character")]
    public CharacterReference Character { get; init; }

    /// <summary>
    /// Gets the protected statistics for the character.
    /// </summary>
    [JsonPropertyName("protected_stats")]
    public ProtectedStats ProtectedStats { get; init; }

    /// <summary>
    /// Gets the character's current position.
    /// </summary>
    [JsonPropertyName("position")]
    public Position Position { get; init; }

    /// <summary>
    /// Gets the bind position of the character's hearthstone.
    /// </summary>
    [JsonPropertyName("bind_position")]
    public Position BindPosition { get; init; }

    /// <summary>
    /// Gets the WoW account for the character.
    /// </summary>
    [JsonPropertyName("wow_account")]
    public int WowAccount { get; init; }
}
