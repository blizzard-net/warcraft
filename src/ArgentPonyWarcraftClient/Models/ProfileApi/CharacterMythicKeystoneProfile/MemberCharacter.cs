namespace ArgentPonyWarcraftClient;

/// <summary>
/// A character who is a party member.
/// </summary>
public record MemberCharacter
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
