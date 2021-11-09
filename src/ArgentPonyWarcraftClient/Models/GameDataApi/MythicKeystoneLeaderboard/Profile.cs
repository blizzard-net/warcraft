namespace ArgentPonyWarcraftClient;

/// <summary>
/// A character profile.
/// </summary>
public record Profile
{
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
    public RealmReferenceWithoutName Realm { get; init; }
}
