namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a pet.
/// </summary>
public record PetReference
{
    /// <summary>
    /// Gets the key for the pet.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the pet.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the pet.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
