namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a realm.
/// </summary>
public record RealmReferenceWithoutName
{
    /// <summary>
    /// Gets the key for the realm.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the ID of the realm.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets a slug for the realm.
    /// </summary>
    [JsonPropertyName("slug")]
    public string Slug { get; init; }
}
