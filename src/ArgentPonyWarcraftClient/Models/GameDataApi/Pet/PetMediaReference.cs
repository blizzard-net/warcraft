namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to pet media.
/// </summary>
public record PetMediaReference
{
    /// <summary>
    /// Gets the key for the pet media.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the ID of the pet.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
