namespace ArgentPonyWarcraftClient;

/// <summary>
/// A World of Warcraft account.
/// </summary>
public record WowAccount
{
    /// <summary>
    /// Gets the ID of the World of Warcraft account.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the characters associated with the World of Warcraft account.
    /// </summary>
    [JsonPropertyName("characters")]
    public AccountCharacter[] Characters { get; init; }
}
