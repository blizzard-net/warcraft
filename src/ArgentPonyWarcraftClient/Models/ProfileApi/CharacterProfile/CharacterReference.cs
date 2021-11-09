namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a character.
/// </summary>
public record CharacterReference
{
    /// <summary>
    /// Gets the key for the character.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the character.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the character.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets a reference to the character's realm.
    /// </summary>
    [JsonPropertyName("realm")]
    public RealmReference Realm { get; init; }
}
