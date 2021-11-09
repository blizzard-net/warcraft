namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a pet ability.
/// </summary>
public record PetAbilityReference
{
    /// <summary>
    /// Gets the key for the pet ability.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the pet ability.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the pet ability.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
